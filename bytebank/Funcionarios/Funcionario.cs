using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Tipo { get; set; }// 1. Presidente , 2. Diretor, 3. Funcionario

        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return this.Salario * 1;
        }
        public Funcionario(int tipo)
        {
            this.Tipo = tipo;
        }
    }
}