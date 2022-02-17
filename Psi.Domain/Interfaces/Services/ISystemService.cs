using Psi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Services
{
    public interface ISystemService
    {
        IList<City> ListCities();
        IList<Country> ListCountries();
    }
}
