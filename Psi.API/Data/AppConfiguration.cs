using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API.Data
{
    public class AppConfiguration
    {
        public string BaseURL { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
    }
}
