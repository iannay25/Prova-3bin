using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Etapa
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNas { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }


        public Funcionario(string nome, string cpf, string matricula, DateTime dataNas, string sexo, double salario)
        {
           this.Nome = nome;
           this.Cpf = cpf;
           this.Matricula = matricula;
           this.DataNas = dataNas;
           this.sexo = sexo;
           this.salario = salario;
        }
    }
}
