using System.Linq;

using Microsoft.AspNetCore.Mvc;

using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Fields
        private readonly ApplicationDbContext _context;

        [HttpGet("{id:int}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var celestialObject = _context.CelestialObjects.Find(id);

            if (celestialObject == null)
                return NotFound();

            celestialObject.Satellites = _context.CelestialObjects.Where(e => e.OrbitedObjectId == id).ToList();
            return Ok(celestialObject);
        }
    }
}
