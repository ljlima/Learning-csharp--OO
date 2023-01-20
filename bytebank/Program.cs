using bytebank.Contas;
using bytebank.Titular;
using bytebank.Funcionarios;
using bytebank.Utilitarios;

Cliente cliente = new Cliente();
ContaCorrente conta = new ContaCorrente(11,"1234-x");

cliente.Nome = "Andre silva";
cliente.Cpf = "123456789";
cliente.Profissao = "Professor";

conta.titular = cliente;    //aponta para o endereco de memoria de cliente
//conta.conta = "1010-X";
//conta.Numero_agencia = 15;
//conta.saldo = 500;

Console.WriteLine("Titular: "+conta.titular.Nome);
Console.WriteLine("CPF: "+conta.titular.Cpf);
Console.WriteLine("Profissão: "+conta.titular.Profissao);
Console.WriteLine("Conta Corrente: "+conta.conta);
Console.WriteLine("Numero Agência: "+conta.Numero_agencia);
System.Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta2 = new ContaCorrente(14,"1588-X");
System.Console.WriteLine(ContaCorrente.TotalContasCriadas);
//Console.WriteLine("Saldo: "+conta.saldo);

Funcionario joao = new Funcionario(1);

joao.Nome = "Joao Silva";
joao.Salario = 5000;
System.Console.WriteLine(joao.Nome);
System.Console.WriteLine("Salario de R$" + joao.Salario);

Diretor Angelo = new Diretor(2);
Angelo.Nome = "Angelo Jorge";
Angelo.Salario = 25000.0;
System.Console.WriteLine(Angelo.Nome);
System.Console.WriteLine("Salario de R$" + Angelo.Salario);

GerenciadorBonificacao Bonificacao = new GerenciadorBonificacao();

Bonificacao.Registrar(joao);
Bonificacao.Registrar(Angelo);

System.Console.WriteLine("Total de Bonificaçaõ no mês R$ " + Bonificacao.TotalBonificacao);
