// See https://aka.ms/new-console-template for more information
using System;
class Programa
{
    static void Main(String[] args){
        string mensagemInicial = "Calculadora Dedução\n";
        Console.WriteLine(mensagemInicial);
        
        double salario = 3300.0, deducao=0.0, imposto=0.0, IR;

        if(salario >= 1900.0 && salario <= 2800.0){
            imposto = 0.075;
            deducao = 142;
       }else if(salario > 2800.0 && salario <= 3751.0){
            imposto = 0.15;
            deducao = 350;
       }else if(salario > 3751.0 && salario <= 4664.0){
            imposto = 0.225;
            deducao = 636;
       }


        IR = imposto*salario - deducao;
        Console.WriteLine("O imposto de renda a ser pago: " + IR + "\n");
        Console.WriteLine("pressione Enter....\n");
        Console.ReadLine();
    }
}

