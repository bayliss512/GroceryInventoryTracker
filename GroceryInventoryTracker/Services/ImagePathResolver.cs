using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace GroceryInventoryTracker.Services
{
    /// <summary>
    /// Utility class for resolving product image paths using a smart matching algorithm.
    /// Handles case-insensitive matching and camelCase/PascalCase conversion.
    /// </summary>
    public class ImagePathResolver
    {
        private readonly string _imageDirectory;
        private readonly string _webImagePath;
        private static readonly object _lockObj = new object();
        private string[] _cachedImageFiles;
        private DateTime _cacheTime;
        private const int CACHE_DURATION_MINUTES = 30;

        public ImagePathResolver(string physicalImageDirectory, string webImagePath)
        {
            _imageDirectory = physicalImageDirectory;
            _webImagePath = webImagePath;
            _cachedImageFiles = null;
            _cacheTime = DateTime.MinValue;
        }

        /// <summary>
        /// Resolves the image path for a given product name using smart matching.
        /// </summary>
        public string ResolveImagePath(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return null;

            var imageFiles = GetCachedImageFiles();
            if (imageFiles == null || imageFiles.Length == 0)
                return null;

            // Try exact match first (case-insensitive)
            var exactMatch = FindExactMatch(productName, imageFiles);
            if (exactMatch != null)
                return exactMatch;

            // Try normalized match
            var normalizedMatch = FindNormalizedMatch(productName, imageFiles);
            if (normalizedMatch != null)
                return normalizedMatch;

            // Try fuzzy match
            var fuzzyMatch = FindFuzzyMatch(productName, imageFiles);
            if (fuzzyMatch != null)
                return fuzzyMatch;

            return null;
        }

        /// <summary>
        /// Gets the list of available image files, using cache when available.
        /// </summary>
        private string[] GetCachedImageFiles()
        {
            lock (_lockObj)
            {
                // Return cached files if cache is still valid
                if (_cachedImageFiles != null && (DateTime.UtcNow - _cacheTime).TotalMinutes < CACHE_DURATION_MINUTES)
                {
                    return _cachedImageFiles;
                }

                // Refresh cache
                if (Directory.Exists(_imageDirectory))
                {
                    _cachedImageFiles = Directory.GetFiles(_imageDirectory, "*.png")
                        .Concat(Directory.GetFiles(_imageDirectory, "*.jpg"))
                        .Concat(Directory.GetFiles(_imageDirectory, "*.jpeg"))
                        .Concat(Directory.GetFiles(_imageDirectory, "*.gif"))
                        .Concat(Directory.GetFiles(_imageDirectory, "*.webp"))
                        .Select(Path.GetFileName)
                        .ToArray();
                    _cacheTime = DateTime.UtcNow;
                    return _cachedImageFiles;
                }

                return null;
            }
        }

        /// <summary>
        /// Finds an exact match (case-insensitive) for the product name.
        /// </summary>
        private string FindExactMatch(string productName, string[] imageFiles)
        {
            var searchName = productName.Trim();
            var searchNameLower = searchName.ToLowerInvariant();

            foreach (var file in imageFiles)
            {
                var fileNameWithoutExt = Path.GetFileNameWithoutExtension(file);
                if (fileNameWithoutExt.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return Path.Combine(_webImagePath, file);
                }
            }

            return null;
        }

        /// <summary>
        /// Finds a normalized match by comparing normalized versions of names.
        /// Handles variations like spaces, underscores, hyphens, and camelCase.
        /// </summary>
        private string FindNormalizedMatch(string productName, string[] imageFiles)
        {
            var normalizedProductName = NormalizeName(productName);

            foreach (var file in imageFiles)
            {
                var fileNameWithoutExt = Path.GetFileNameWithoutExtension(file);
                var normalizedFileName = NormalizeName(fileNameWithoutExt);

                if (normalizedProductName.Equals(normalizedFileName, StringComparison.OrdinalIgnoreCase))
                {
                    return Path.Combine(_webImagePath, file);
                }
            }

            return null;
        }

        /// <summary>
        /// Finds a fuzzy match by checking if the file name contains key words from product name.
        /// </summary>
        private string FindFuzzyMatch(string productName, string[] imageFiles)
        {
            var keywords = ExtractKeywords(productName);
            if (keywords.Length == 0)
                return null;

            var bestMatch = imageFiles
                .Select(file => new { File = file, Score = CalculateMatchScore(file, keywords) })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .FirstOrDefault();

            if (bestMatch != null)
            {
                return Path.Combine(_webImagePath, bestMatch.File);
            }

            return null;
        }

        /// <summary>
        /// Normalizes a name by converting to lowercase, handling camelCase/PascalCase,
        /// and replacing various separators with a standard format.
        /// </summary>
        private string NormalizeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;

            // Convert CamelCase to space-separated
            var withSpaces = Regex.Replace(name, "([a-z])([A-Z])", "$1 $2");

            // Convert to lowercase
            var lower = withSpaces.ToLowerInvariant();

            // Replace various separators with spaces
            lower = Regex.Replace(lower, @"[_\-\s]+", " ");

            // Remove extra spaces
            lower = Regex.Replace(lower, @"\s+", " ").Trim();

            return lower;
        }

        /// <summary>
        /// Extracts keywords from product name for fuzzy matching.
        /// </summary>
        private string[] ExtractKeywords(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return new string[0];

            var normalized = NormalizeName(productName);
            return normalized.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Calculates match score between a file and keywords.
        /// Higher score means better match.
        /// </summary>
        private int CalculateMatchScore(string fileName, string[] keywords)
        {
            var fileNameNormalized = NormalizeName(Path.GetFileNameWithoutExtension(fileName));
            var score = 0;

            foreach (var keyword in keywords)
            {
                if (fileNameNormalized.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    // Give more points for complete keyword match
                    var words = fileNameNormalized.Split(' ');
                    if (words.Any(w => w.Equals(keyword, StringComparison.OrdinalIgnoreCase)))
                    {
                        score += 10;
                    }
                    else
                    {
                        score += 5;
                    }
                }
            }

            return score;
        }
    }
}
