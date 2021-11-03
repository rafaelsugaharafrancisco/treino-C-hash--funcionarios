using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFuncionarios.Interface
{
    interface IRepositorio<T>
    {
        public List<T> Listar();
        public T RetornarPorId(int id);
        public void Inserir(T objeto);
        public void Alterar(int id, T objeto);
        public void Excluir(int id);
    }
}
