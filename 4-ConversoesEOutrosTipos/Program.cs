using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos");

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;

        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);


        long x;
        x = 2000000000000;
        Console.WriteLine(x);


        short y; //Valores até 16bits
        y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f; // Não é tão precisa 
        Console.WriteLine(altura);



        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


