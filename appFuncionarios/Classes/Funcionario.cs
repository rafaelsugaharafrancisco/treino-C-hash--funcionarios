using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using appFuncionarios.Enum;


namespace appFuncionarios.Classes
{
    class Funcionario : Pessoa
    {
        protected int Id { get; set; }
        protected Cargo TipoDeCargo { get; set; }
        protected decimal Salario { get; set; }
        public Funcionario(int id, 
                           string nome, 
                           string email, 
                           string telefone, 
                           DateTime dataNascimento, 
                           Cargo tipoDeCargo,
                           decimal salario) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
            this.TipoDeCargo = tipoDeCargo;
            this.Salario = salario;
        }

        public override string ToString()
        {
            string retorno = "";
            string data = $"{ this.DataNascimento.Day}/{ this.DataNascimento.Month }/{ this.DataNascimento.Year }";

            retorno += "Id:" + this.Id + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Email: " + this.Email + Environment.NewLine;
            retorno += "Telefone: " + this.Telefone + Environment.NewLine;
            retorno += $"Data de Nascimento: { data }" + Environment.NewLine;
            retorno += "Tipo de Cargo: " + this.TipoDeCargo + Environment.NewLine;
            retorno += "Salario: R$ " + this.Salario + Environment.NewLine;

            return retorno;
        }

        public int GetId()
        {
            return this.Id;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public void SetTipoDeCargo(Cargo cargo)
        {
            this.TipoDeCargo = cargo;
        }

        public void SetSalario(decimal salario)
        {
            this.Salario = salario;
        }
    }
}
