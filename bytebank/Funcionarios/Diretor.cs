using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Tipo { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return this.Salario*2;
        }
        public Diretor(int tipo)
        {
            this.Tipo = tipo;
        }
    }
}