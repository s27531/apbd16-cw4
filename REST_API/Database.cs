using REST_API.Models;

namespace REST_API;

public class Database
{
    public static List<Animal> Animals = new()
    {
        new Animal() { Id = 1, Name = "Fafik", Category = "dog", Colour = "gray" },
        new Animal() { Id = 2, Name = "Fifek", Category = "dog", Colour = "gray" },
        new Animal() { Id = 3, Name = "Baltazar", Category = "cat", Colour = "gray" },
        new Animal() { Id = 4, Name = "Ugryź", Category = "pies", Colour = "black" },
    };

    public static List<Visit> Visits = new()
    {
        new Visit() { Date = DateTime.Now, Animal = Animals[0], Description = "Lorem ipsum dolor sit...", Price = 49.99 },
        new Visit() { Date = DateTime.Now, Animal = Animals[2], Description = "Description1...", Price = 149.99 },
        new Visit() { Date = DateTime.Now, Animal = Animals[3], Description = "Description2...", Price = 29.99 },
        
    };
}