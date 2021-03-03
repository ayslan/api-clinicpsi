using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API.Base
{
    public class ResponseResult<T>
    {
        public bool Success { get; set; }
        public List<T> Data { get; set; }
        public dynamic Info { get; set; }
    }
}
