using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    public class Salario
    {
        public double SalarioBruto { get; set; }

        public double SalarioLiquido { get; set; }

        public int Dependentes { get; set; }

        public Salario(double salarioBruto, int dependentes)
        {
            SalarioBruto = salarioBruto;
            SalarioLiquido = salarioBruto;
            Dependentes = dependentes;
        }

        public double DescontarDoSalarioBruto(List<IImposto> impostos)
        {
            impostos.ForEach(imposto =>
            {
                SalarioLiquido -= imposto.Desconta(Salario);
            });

            return SalarioLiquido;
        }
    }
}
