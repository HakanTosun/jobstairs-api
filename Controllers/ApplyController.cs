using Microsoft.AspNetCore.Mvc;

namespace JobStairsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplyController : ControllerBase
    {
        public class Applicant
        {
            public string Name { get; set; } = "";
            public string Email { get; set; } = "";
            public string Position { get; set; } = "";
        }

        [HttpPost]
        public IActionResult Post([FromBody] Applicant applicant)
        {
            if (string.IsNullOrWhiteSpace(applicant.Name) || string.IsNullOrWhiteSpace(applicant.Email))
            {
                return BadRequest(new { message = "Ungültige Daten" });
            }

            return Ok(new { message = "Bewerbung erfolgreich empfangen" });
        }
    }
}