using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    public class Inss : IImposto
    {
        public double Desconta(Salario salario)
        {
            return salario.SalarioLiquido -= ValorInss(salario.SalarioBruto);
        }

        private double ValorInss(double valorBruto)
        {
            double inss = 0;
            if (valorBruto <= 1100)
            {
                inss = valorBruto * 0.075;
            }
            else if (valorBruto > 1100 && valorBruto <= 2203.48)
            {
                inss = (valorBruto * 0.09) - 16.50;
            }
            else if (valorBruto > 2203.48 && valorBruto <= 3305.22)
            {
                inss = (valorBruto * 0.12) - 82.61;
            }
            else if (valorBruto > 3305.22 && valorBruto <= 6433.57)
            {
                inss = (valorBruto * 0.14) - 148.72;
            }
            else if (valorBruto > 6433.57)
            {
                inss = 751.99;
            }
            else
            {
                Console.Error.Write("Erro ao calcular o INSS!");
            }
            return inss;
        }
    }
}
