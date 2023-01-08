using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private string numero_agencia;
        public string Numero_agencia
        {
            get { return this.numeroAgencia; }
            set {
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string conta { get; set; };
        public Cliente titular { get; set; };
        private double saldo = 100;


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