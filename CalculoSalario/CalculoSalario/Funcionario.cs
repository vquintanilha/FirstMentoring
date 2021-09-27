using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    class Funcionario
    {
        public String Nome { get; set; }

        public Salario Salario { get; set; }

        public int Dependentes { get; set; }

        public Funcionario(string nome, Salario salario, int dependentes)
        {
            Nome = nome;
            Salario = salario;
            Dependentes = dependentes;
        }
    }
}
