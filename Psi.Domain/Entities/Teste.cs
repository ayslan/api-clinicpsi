using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Entities
{
    public class Teste : BaseEntity<int, Teste>
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Sobrenome { get; set; }
    }
}
