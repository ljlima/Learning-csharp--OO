// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double investimento = 1000, taxa = 0.005;
int mes = 1;


// while(mes <= 12){
//     investimento = investimento + investimento*taxa;
//     Console.WriteLine(investimento);
//     mes++;
// }

for(mes=1;mes<=12;mes++){
    investimento *= 1.005;
    Console.WriteLine("Seu investimento acumulado é R$ " + investimento);
}