using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string LocalName { get; set; }
        public string ISOCode { get; set; }
        public int? PhoneCode { get; set; }
    }
}
