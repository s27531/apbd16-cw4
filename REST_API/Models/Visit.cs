namespace REST_API.Models;

public class Visit
{
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}