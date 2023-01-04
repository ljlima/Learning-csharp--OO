using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public Cliente titular;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(valor <= this.saldo)
            {
                destino.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}