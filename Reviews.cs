using System;

public class Reviews
{
    // Private fields for encapsulation
    private int reviewId;
    private string product;
    private string customer;
    private int rating;
    private string reviewText;
    private DateTime reviewDate;

    // Constructor to initialize the reviewed object
    public Reviews(int reviewId, string product, string customer, int rating, string reviewText, DateTime? reviewDate = null)
    {
        try
        {
            //Initialize the properties with validation
            this.ReviewId = reviewId;
            this.Product = product;
            this.Customer = customer;
            this.Rating = rating;
            this.ReviewText = reviewText;
            this.ReviewDate = reviewDate ?? DateTime.Now; // Defaults to the current date if one isnt provided
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing the review: {ex.Message}");
        }
    }

    // Property for the ReviewId with validation to make sure it is positive
    public int ReviewId
    {
        get { return reviewId; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("ReviewId must be a positive integer.");
            reviewId = value;
        }
    }

    // Property for Product with validation to make sure it's not empty or null
    public string Product
    {
        get { return product; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Product name cannot be empty or null.");
            product = value;
        }
    }

    // Property for customer with validation to make sure it's not empty or null
    public string Customer
    {
        get { return customer; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Customer name cannot be empty or null.");
            customer = value;
        }
    }

    //Property for rating with validation to make sure it's not empty or null
    public int Rating
    {
        get { return rating; }
        set
        {
            if (value < 1 || value > 5)
                throw new ArgumentException("Rating must be between 1 and 5.");
            rating = value;
        }
    }

    //Property for ReviewText with validation to make sure it's not empty or null
    public string ReviewText
    {
        get { return reviewText; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Review text cannot be empty or null.");
            reviewText = value;
        }
    }

    //Property for ReviewDate with validation to make sure it's not a date in the future
    public DateTime ReviewDate
    {
        get { return reviewDate; }
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Review date cannot be in the future.");
            reviewDate = value;
        }
    }

    // Method to display review details
    public void DisplayReview()
    {
        try
        {
            Console.WriteLine("Review Details:");
            Console.WriteLine($"  ReviewId: {ReviewId}");
            Console.WriteLine($"  Product: {Product}");
            Console.WriteLine($"  Customer: {Customer}");
            Console.WriteLine($"  Rating: {Rating}");
            Console.WriteLine($"  ReviewText: {ReviewText}");
            Console.WriteLine($"  ReviewDate: {ReviewDate}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error displaying the review: {ex.Message}");
        }
    }
}
