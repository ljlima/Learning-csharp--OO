using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank.Utilitarios
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; set; }
        public double Registrar(Funcionario funcionario)
        {
            return this.TotalBonificacao += funcionario.GetBonificacao();
        }
        public double Registrar(Diretor diretor)
        {
            return this.TotalBonificacao += diretor.GetBonificacao();
        }
    }
}