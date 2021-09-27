using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuSalario = new Salario();
            Console.WriteLine("Digite seu salário");
            meuSalario.SalarioBruto = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine($"Salário Liquido {meuSalario.SalarioLiquido}");
        }
    }
}
