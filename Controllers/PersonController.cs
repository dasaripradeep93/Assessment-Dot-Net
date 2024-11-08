using Assessment.Models;
using Assessment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService) 
        { 
            _personService = personService;
        }

        [HttpPost]
        public IActionResult SavePerson([FromBody]Person person)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var savedPerson = _personService.SavePerson(person);
            return Ok(savedPerson);
        }
    }
}
