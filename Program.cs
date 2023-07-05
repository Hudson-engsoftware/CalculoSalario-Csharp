using System;
using System.Globalization;

namespace segundoProjeto{

    class Funcionario{

        public static void Main( String[]args){

            Funcionario funcionario = new Funcionario();


            Console.Write(" Nome :");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto : ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write(" Imposto :");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario" + funcionario ) ;

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o Salario em qual porcentagem :");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine(  );
            Console.WriteLine( "Dados Atualizados : " + funcionario);


        }
    }
}