using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 1000.0;

Console.WriteLine("O saldo na conta do " + contaDoAndre.titular + " é " + contaDoAndre.saldo);

contaDoAndre.Depositar(4000.0);

Console.WriteLine("Depois do deposito, saldo na conta do " + contaDoAndre.titular + " é R$ " + contaDoAndre.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();

contaDaMaria.titular = "Maria Souza";
contaDaMaria.numeroAgencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 500;

if(contaDoAndre.Transferir(10000, contaDaMaria))
{
    Console.WriteLine("Transferencia realizada com sucesso!");
    Console.WriteLine("Seu saldo é de R$ "+contaDoAndre.saldo);
    Console.WriteLine("O saldo de Maria R$ "+contaDaMaria.saldo);
}
else
{
    Console.WriteLine("Não foi possível realizar a transferencia!");
    Console.WriteLine("Saldo insuficiente!");
}