namespace BlazingShop.Models;

public class Product
{
    public Product()
    {

    }
    public Product(int id, string name, string description, string image, decimal price, int categoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
}
