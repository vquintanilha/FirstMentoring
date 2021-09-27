using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    public class ImpostoDeRenda : IImposto
    {
        public double Desconta(Salario salario)
        {
            salario.SalarioLiquido -= (salario.Dependentes * 189.59);
            return salario.SalarioLiquido -= ValorImpostoDeRenda(salario.SalarioLiquido);
        }

        private double ValorImpostoDeRenda(double valorBruto)
        {
            double IRR = 0;
            if (valorBruto <= 1903.98)
            {
                IRR = 0;
            }
            else if (valorBruto > 1903.98 && valorBruto <= 2826.65)
            {
                IRR = (valorBruto * 0.075) - 142.80;
            }
            else if (valorBruto > 2826.65 && valorBruto <= 3751.05)
            {
                IRR = (valorBruto * 0.15) - 354.80;
            }
            else if (valorBruto > 3751.05 && valorBruto <= 4664.68)
            {
                IRR = (valorBruto * 0.225) - 636.13;
            }
            else if (valorBruto > 4664.68)
            {
                IRR = (valorBruto * 0.275) - 869.36;
            }
            else
            {
                Console.Error.Write("Erro ao calcular o INSS!");
            }
            return IRR;
        }
    }
}
