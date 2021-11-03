using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFuncionarios.Classes
{
    abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected string Email { get; set; }
        protected string Telefone { get; set; }
        protected DateTime DataNascimento { get; set; }
    }
}
