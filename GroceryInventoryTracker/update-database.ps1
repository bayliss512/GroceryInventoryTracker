#!/usr/bin/env pwsh
<#
.SYNOPSIS
	Database migration helper script for GroceryInventoryTracker

.DESCRIPTION
	This script helps manage database migrations for the project.
	Use it to easily update, rollback, or reset the database.

.EXAMPLE
	.\update-database.ps1 -Action Update
	.\update-database.ps1 -Action Rollback
	.\update-database.ps1 -Action Reset
#>

param(
	[Parameter(Mandatory=$true)]
	[ValidateSet("Update", "Rollback", "Reset")]
	[string]$Action
)

# Colors for output
$Green = "`e[32m"
$Yellow = "`e[33m"
$Red = "`e[31m"
$Reset = "`e[0m"

function Write-Success {
	Write-Host "${Green}✓ $args${Reset}"
}

function Write-Info {
	Write-Host "${Yellow}ℹ $args${Reset}"
}

function Write-Error {
	Write-Host "${Red}✗ $args${Reset}"
}

Write-Info "GroceryInventoryTracker - Database Migration Helper"
Write-Info "Action: $Action"
Write-Info ""

try {
	switch ($Action) {
		"Update" {
			Write-Info "Applying latest migrations..."
			dotnet ef database update
			Write-Success "Database updated successfully!"
			Write-Info "✓ Migrations applied"
			Write-Info "✓ Seed data loaded"
			Write-Info "✓ Ready to use"
		}

		"Rollback" {
			Write-Info "Rolling back to previous migration..."
			Write-Info "This will revert: RemoveQuantityColumnsFromProducts"
			$confirm = Read-Host "Continue? (y/n)"
			if ($confirm -eq 'y') {
				dotnet ef database update AddLocationToShipments
				Write-Success "Rolled back to previous migration!"
			} else {
				Write-Info "Rollback cancelled."
			}
		}

		"Reset" {
			Write-Info "Resetting database to initial state..."
			Write-Info "This will:"
			Write-Info "  1. Drop all tables"
			Write-Info "  2. Re-apply all migrations"
			Write-Info "  3. Re-seed all data"
			Write-Info ""
			$confirm = Read-Host "Continue? (y/n)"
			if ($confirm -eq 'y') {
				Write-Info "Dropping existing database..."
				dotnet ef database drop --force
				Write-Success "Database dropped"

				Write-Info "Creating new database with migrations..."
				dotnet ef database update
				Write-Success "Database recreated successfully!"
				Write-Info "✓ All migrations applied"
				Write-Info "✓ All seed data loaded"
				Write-Info "✓ Ready to use"
			} else {
				Write-Info "Reset cancelled."
			}
		}
	}

	Write-Info ""
	Write-Success "Operation completed!"
}
catch {
	Write-Error "Operation failed: $_"
	exit 1
}
