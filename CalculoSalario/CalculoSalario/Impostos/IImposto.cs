using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    public interface IImposto
    {
        public double Desconta(Salario salario);
    }
}
