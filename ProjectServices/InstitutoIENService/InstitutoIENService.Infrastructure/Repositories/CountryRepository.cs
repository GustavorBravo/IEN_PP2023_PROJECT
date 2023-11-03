using InstitutoIENService.Core.Entities;
using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoIENService.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly InstitutoIencursoContext _context;
        public CountryRepository(InstitutoIencursoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Paise>> GetCountries()
        {
            var countries = await _context.Paises.ToListAsync();
            return countries;
        }
    }
}

