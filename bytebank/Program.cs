using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 1000.0;

Console.WriteLine("O saldo na conta do " + contaDoAndre.titular + " é " + contaDoAndre.saldo);

contaDoAndre.Depositar(4000.0);

Console.WriteLine("Depois do deposito, saldo na conta do " + contaDoAndre.titular + " é R$ " + contaDoAndre.saldo);