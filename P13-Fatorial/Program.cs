using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Exercicio Multiplos de 3");

        int fatorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;   
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


