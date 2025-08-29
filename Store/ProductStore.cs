using System;
using System.Collections.Generic;
using RazorPagesCRUD.Models;

namespace RazorPagesCRUD.Store;

public class ProductStore
{
    private List<Products> _products = new()
    {
        new Products
        {
            Id = Guid.NewGuid(),
            Name = "Product 1",
            Price = 10.0m,
            Description = "Description for Product 1"
        },
        new Products
        {
            Id = Guid.NewGuid(),
            Name = "Product 2",
            Price = 20.0m,
            Description = "Description for Product 2"
        }
    };

    public IEnumerable<Products> GetAll() => _products;
    public Products? GetById(Guid id) => _products.FirstOrDefault(p => p.Id == id);
    public void Add(Products product) => _products.Add(product);
    public void Update(Products product)
    {
        var existingProduct = GetById(product.Id);
        if (existingProduct is null) return;
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.Description = product.Description;
    }
    public bool Delete(Guid id)
    {
        var product = GetById(id);
        if (product is null) return false;
        return _products.Remove(product);
    }
}
