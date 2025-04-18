using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return NotFound();

            var visits = Database.Visits.Where(v => v.Animal == animal).ToList();
            return Ok(visits);
        }
    }
}
