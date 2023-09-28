using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Etapa
{
    internal class Administrativo
    {
       public double Salario(double salario)
       {
            double s = salario + 250 % 0.17;
            return s;

       }


    }
}
