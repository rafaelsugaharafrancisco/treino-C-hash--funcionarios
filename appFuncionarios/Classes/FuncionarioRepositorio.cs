using appFuncionarios.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFuncionarios.Classes
{
    class FuncionarioRepositorio : IRepositorio<Funcionario>
    {
        private List<Funcionario> lista = new List<Funcionario>();
        public void Alterar(int id, Funcionario funcionario)
        {
            this.lista[id] = funcionario;
        }

        public void Excluir(int id)
        {
            this.lista.Remove(RetornarPorId(id));
        }

        public void Inserir(Funcionario novoFuncionario)
        {
            this.lista.Add(novoFuncionario);
        }

        public List<Funcionario> Listar()
        {
            return this.lista;
        }

        public Funcionario RetornarPorId(int id)
        {
            return this.lista.Find(funcionario => funcionario.GetId() == id);
        }
    }
}
