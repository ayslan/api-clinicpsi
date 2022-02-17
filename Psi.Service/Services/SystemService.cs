using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Service.Services
{
    public class SystemService : ISystemService
    {
        private readonly IGlobalUnitOfWork _globalUoW;

        public SystemService(IGlobalUnitOfWork globalUoW)
        {
            _globalUoW = globalUoW;
        }

        public IList<City> ListCities()
        {
            return _globalUoW.CityRepository.List().OrderBy(x => x.State).ThenBy(x => x.Name).ToList();
        }

        public IList<Country> ListCountries()
        {
            return _globalUoW.CountryRepository.List().OrderBy(x => x.Name).ToList();
        }
    }
}
