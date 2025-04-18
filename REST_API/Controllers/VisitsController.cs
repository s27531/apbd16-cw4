using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {

        [HttpGet("{animalId}")]
        public IActionResult Get(int animalId)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == animalId);
            if (animal == null)
            {
                return NotFound();
            }

            var visits = Database.Visits.Where(v => v.Animal == animal).ToList();
            return Ok(visits);
        }

        [HttpPost("{animalId}")]
        public IActionResult Add(int animalId, Visit visit)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == animalId);
            if (animal == null)
            {
                return NotFound();
            }
            
            visit.Animal = animal;
            Database.Visits.Add(visit);
            return Created();
        }
    }
}
