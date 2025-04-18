namespace REST_API.Models;

public class Visit
{
    DateOnly Date { get; set; }
    Animal Animal { get; set; }
    string Description { get; set; }
    double Price { get; set; }
}