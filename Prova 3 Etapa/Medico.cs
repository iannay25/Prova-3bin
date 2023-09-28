using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Etapa
{
    internal class Medico : Funcionario
    {
        public string Crm { get; set; }
        public string Especialidade { get; set; }
        public double HoraExtra { get; set; }


        public Medico(string nome, string cpf, string matricula, DateTime dataNas, string sexo, double salario, string crm, string especialidade, double horaExtra) : base ( nome,cpf, matricula, dataNas, sexo, salario)
        {
            this.Crm = crm;
            this.Especialidade = especialidade;
            this.HoraExtra = horaExtra;
        }

       public double Beneficio(double salario)
       {
            double s = salario % 0.22;
            return s;
       }
     
    }
}
