using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
            return Ok(animal);
        }

        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Animals.Add(animal);
            return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Animal animal)
        {
            var oldAnimal = Database.Animals.FirstOrDefault(x => x.Id == id);
            if (oldAnimal == null)
            {
                return NotFound();
            }
            Database.Animals.Remove(oldAnimal);
            Database.Animals.Add(animal);
            return NoContent(); // According to MDM web docs
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
            if (animal == null)
                return NotFound();

            Database.Animals.Remove(animal);
            return NoContent();
        }

        [HttpGet("by-name/{name}")]
        public IActionResult GetAllByName(string name)
        {
            var animals = Database.Animals.FindAll(x => x.Name == name);
            return Ok(animals);
        }
        
    }
}
