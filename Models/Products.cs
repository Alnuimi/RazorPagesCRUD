using System;

namespace RazorPagesCRUD.Models;

public class Products
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
}
