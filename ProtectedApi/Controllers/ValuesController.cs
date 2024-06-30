using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var username = User.Identity.Name;
            return Ok(new
            {
                Username = username,
                Section = "Section Name",
                Course = "Course Name",
                FunFacts = new List<string>
                {
                    "Fact 1",
                    "Fact 2",
                    "Fact 3",
                    "Fact 4",
                    "Fact 5",
                    "Fact 6",
                    "Fact 7",
                    "Fact 8",
                    "Fact 9",
                    "Fact 10"
                }
            });
        }
    }
}