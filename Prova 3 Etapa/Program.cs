using System;
using Prova_3_Etapa;
class Prova
{
    static void Main(string[] args)
    {
        int op = 0;
        try
        {
            while (true)
            {
                Console.WriteLine("Olá! Digite tais informações... ");

                Console.WriteLine("Informe seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe seu cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe sua matrícula: ");
                string matricula = Console.ReadLine();

                Console.WriteLine("Informe sua data de nascimento: ");
                DateTime datanas = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe seu sexo: ");
                string sexo = Console.ReadLine();

                Console.WriteLine("Informe seu salário:");
                double salario = Convert.ToDouble(Console.ReadLine());

                Funcionario f = new Funcionario(nome, cpf, matricula, datanas, sexo, salario);

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1-Médico");
                Console.WriteLine("2-Administrativo");
                Console.WriteLine("3-Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if(opcao == 1)
                {
                    Console.WriteLine("Adicione as seguintes informações: ");
                    Console.WriteLine("CRM: ");
                    string crm = Console.ReadLine();

                    Console.WriteLine("Especialidade: ");
                    string especialidade = Console.ReadLine();

                    Console.WriteLine("Hora extra: ");
                    string horaex = Console.ReadLine();

                    Console.WriteLine("Benefício: ");
                    double s = Convert.ToInt32(Console.ReadLine());
                    
                }

               
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe seu salário: ");
                    double sal = Convert.ToInt32(Console.ReadLine());
                   
                }

                break;
            
            }
        }

        catch (Exception ex)
        { Console.WriteLine(); }
    }
}
         
