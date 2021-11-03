using appFuncionarios.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFuncionarios.Classes
{
    class Formulario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cargo TipoDeCargo { get; set; }
        public decimal Salario { get; set; }
    }
}
