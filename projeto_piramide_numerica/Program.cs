using System;
class Programa{
    static void Main(String[] args){
    int contadorColuna, contadorLinha;
    for(contadorLinha=1;contadorLinha<=5;contadorLinha++){
        Console.WriteLine();
        for(contadorColuna=1;contadorColuna<=contadorLinha;contadorColuna++){
            Console.Write(contadorColuna);
        }
    }
}
}
