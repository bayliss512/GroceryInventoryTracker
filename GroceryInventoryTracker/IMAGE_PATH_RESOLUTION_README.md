# Image Path Resolution System

## Overview
This document describes the smart image path resolution system implemented for the Grocery Inventory Tracker.

## Architecture

### Components

1. **ImagePathResolver (Services/ImagePathResolver.cs)**
   - Smart matching algorithm for finding product images
   - Supports multiple matching strategies:
	 - Exact match (case-insensitive)
	 - Normalized match (handles camelCase, underscores, hyphens)
	 - Fuzzy match (keyword-based matching)
   - Implements caching to avoid repeated file system lookups (30-minute cache duration)

2. **ProductService (Services/ProductService.cs)**
   - Initialized with IWebHostEnvironment dependency
   - Provides ResolveProductImagePath(productName) method
   - Constants:
	 - PRODUCT_IMAGES_DIRECTORY = "Images/ProductImages"
	 - WEB_IMAGE_PATH = "/Images/ProductImages"

3. **IndexModel (Pages/Index.cshtml.cs)**
   - Calls ProductService.ResolveProductImagePath() for each product
   - Dynamically updates Product.ImagePath before rendering
   - Falls back to original ImagePath if resolution fails

## Image Directory
- Location: `C:\Users\cbayl\source\repos\GroceryInventoryTracker\GroceryInventoryTracker\Images\ProductImages`
- Web accessible at: `/Images/ProductImages`
- Contains 288 product images in PNG format

## Matching Algorithm

### Matching Strategy (in order of precedence)

1. **Exact Match**
   - Product name matches filename exactly (case-insensitive)
   - Example: "Apples" → "Apples.png" ✓

2. **Normalized Match**
   - Converts both product name and filename to normalized form
   - Handles:
	 - CamelCase conversion (e.g., "BellPeppers" → "Bell Peppers")
	 - Space/underscore/hyphen normalization
   - Example: "Sweet_potatoes" → "Sweet potatoes.png" ✓

3. **Fuzzy Match**
   - Extracts keywords from product name
   - Matches files containing the keywords
   - Scores based on keyword coverage
   - Example: "Ground beef" → "Ground beef.png" ✓

### Caching
- File lists are cached for 30 minutes
- Thread-safe caching using lock mechanism
- Cache is automatically refreshed when expired

## Example Matching Results

| Product Name | Filename | Match Type | Result |
|---|---|---|---|
| Apples | Apples.png | Exact | ✓ |
| Sweet potatoes | Sweet potatoes.png | Exact | ✓ |
| Ground beef | Ground beef.png | Exact | ✓ |
| Beef steaks | Beef steaks.png | Exact | ✓ |
| Chicken breasts | Chicken breasts.png | Exact | ✓ |

## Benefits

1. **Automatic Image Discovery**: No need to manually update image paths in the database
2. **Flexibility**: Handles various naming conventions automatically
3. **Maintainability**: Easy to add new products without updating image paths
4. **Performance**: Caching prevents repeated file system lookups
5. **Robustness**: Multiple matching strategies ensure best results

## Usage

### In Code
```csharp
// Get resolved image path for a product
var imagePath = productService.ResolveProductImagePath("Apples");
// Result: "/Images/ProductImages/Apples.png"
```

### In Razor Pages
The Index.cshtml automatically displays resolved image paths through the dynamic resolution in IndexModel.OnGetAsync().

## Configuration

To change the image directory path:
1. Edit PRODUCT_IMAGES_DIRECTORY constant in ProductService.cs
2. Edit WEB_IMAGE_PATH constant in ProductService.cs
3. Rebuild and restart the application
