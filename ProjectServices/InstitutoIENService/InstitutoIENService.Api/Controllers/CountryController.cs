using InstitutoIENService.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoIENService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCountry()
        {
            var countries = new CountryRepository().GetCountries();
            return Ok(countries);
        }
    }
}
