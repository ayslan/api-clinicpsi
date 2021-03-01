using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Models
{
    public class CreateTesteModel
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Sobrenome { get; set; }
        public string ABC { get; set; }
        public int Idade { get; set; }
    }
}
