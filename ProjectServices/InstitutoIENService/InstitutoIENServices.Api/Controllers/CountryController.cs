using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoIENServices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task<IActionResult> GetCountry()
        {
            var countries = await _countryRepository.GetCountries();
            return Ok(countries);
        }
    }
}
