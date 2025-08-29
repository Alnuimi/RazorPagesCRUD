# RazorPagesCRUD

Simple ASP.NET Core Razor Pages sample app demonstrating CRUD operations for a Product model.

## Summary

This repo is a minimal Razor Pages application (TargetFramework: .NET 9.0) that implements Create, Read, Update and Delete pages for a `Products` model backed by a simple in-memory `ProductStore`.

## Features

- List products
- Create new product
- View product details
- Edit product
- Delete product

## Key files

- `Program.cs` - app startup and service registration
- `Store/ProductStore.cs` - in-memory repository for products
- `Models/Products.cs` - product model
- `Pages/Products/Index.cshtml(.cs)` - product list
- `Pages/Products/Create.cshtml(.cs)` - create page
- `Pages/Products/Edit.cshtml(.cs)` - edit page
- `Pages/Products/Delete.cshtml(.cs)` - delete confirmation
- `Pages/Products/Details.cshtml(.cs)` - details page
- `Pages/Shared/_Layout.cshtml` - basic layout


## Prerequisites

- .NET 9 SDK installed (dotnet)

You can confirm with:

```powershell
dotnet --version
```

## Run locally (Windows PowerShell)

From the repository root (`g:\programms\RazorPagesCRUD`) run:

```powershell
# restore (optional), build and run
dotnet restore; dotnet build; dotnet run
```

By default the app uses the launch profile configured for HTTPS. The app URL shown in `Properties/launchSettings.json` is `https://localhost:7294` — open that URL in your browser and navigate to `/Products` or click "Add Product" in the UI.

## Routes

- `/Products` - list
- `/Products/Create` - create
- `/Products/Edit?id={guid}` - edit
- `/Products/Delete?id={guid}` - delete confirmation
- `/Products/Details?id={guid}` - details

(They are implemented as Razor Pages under `Pages/Products` — pages that accept an `id` use the route `{id:guid}` in the page directive.)

## Notes & Next steps

- The `ProductStore` is in-memory and not persistent. For production replace it with a database-backed repository.
- Consider adding server-side validation attributes to `Models/Products` and adding tests.
- If you hit runtime/build errors, run `dotnet build` and inspect the output in PowerShell; the README does not modify code.

## License

This repository contains example code and is provided as-is.
