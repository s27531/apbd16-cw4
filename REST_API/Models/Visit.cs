namespace REST_API.Models;

public class Visit
{
    public DateTime Date { get; set; }
    public Animal? Animal { get; set; } // ? to add new visit without creating DTO at this point.
    public string Description { get; set; }
    public double Price { get; set; }
}