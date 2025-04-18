using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        
    }
}
