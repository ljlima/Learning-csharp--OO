// See https://aka.ms/new-console-template for more information
using System;
class Programa
{
    static void Main(String[] args){
        Console.WriteLine("Hello, World!\n");
        double nota1, nota2, soma;

        nota1 = 2.65;
        nota2 = 3.09;
        soma = nota1 + nota2;
        Console.WriteLine("A soma total das notas é: " + soma   + "\n" + "Execução em :"  + DateTime.Now);
        Console.WriteLine("pressione Enter....\n");
        Console.ReadLine();
    }
}

