using System;

public class Categories
{
    // Private fields for encapsulation
    private int categoryId;
    private string name;
    private string description;
    private string product;

    // Constructor
    public Categories(int categoryId, string name, string description, string product)
    {
        try
        {
            this.CategoryId = categoryId;
            this.Name = name;
            this.Description = description;
            this.Product = product;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing the category: {ex.Message}");
        }
    }

    // Properties with validation
    public int CategoryId
    {
        get { return categoryId; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("CategoryId must be a positive integer.");
            categoryId = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or null.");
            name = value;
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Description cannot be empty or null.");
            description = value;
        }
    }

    public string Product
    {
        get { return product; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Product cannot be empty or null.");
            product = value;
        }
    }

    // Method to display category details
    public void DisplayCategory()
    {
        try
        {
            Console.WriteLine("Category Details:");
            Console.WriteLine($"  CategoryId: {CategoryId}");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"  Description: {Description}");
            Console.WriteLine($"  Product: {Product}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error displaying the category: {ex.Message}");
        }
    }
}
