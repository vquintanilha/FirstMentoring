using System;
using System.Collections.Generic;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            var inss = new Inss();
            var irr = new ImpostoDeRenda();
            var listaDeImposto = new List<IImposto>
            {
                inss,
                irr
            };

            Console.WriteLine("Digite o nome do funcionário: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto deste funcionário: ");
            var salarioBruto = Console.ReadLine();

            Console.WriteLine("Digite quantos dependentes este funcionário tem: ");
            var dependentes = Console.ReadLine();

            Console.WriteLine("\n==================================================\n");
            var salario = new Salario(Convert.ToDouble(salarioBruto), Convert.ToInt32(dependentes));

            salario.DescontarDoSalarioBruto(listaDeImposto);

            var funcionario = new Funcionario(nome, salario, Convert.ToInt32(dependentes));

            Console.WriteLine($"O salário líquido do funcionário {nome} é de: {funcionario.Salario.SalarioLiquido:C}");
        }
    }
}
