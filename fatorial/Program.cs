using System;
class Programa {
    static void Main(String[] args){
       
        int fatorial=1, numeroAtual;

        Console.WriteLine("**************Calculo de fatorial*******************\n");
        Console.WriteLine("Insita o numero que deseja calcular o fatorial: \n");
        int entradaUsuario = Int32.Parse(Console.ReadLine());
        for(numeroAtual=1;numeroAtual <= entradaUsuario;numeroAtual++){
            fatorial *= numeroAtual;
        }
        Console.WriteLine("Fatorial de " + entradaUsuario + " é " + fatorial + "\n");
    }
}
