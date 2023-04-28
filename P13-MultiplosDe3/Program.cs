using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Exercicio Multiplos de 3");


        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);

            }
        }

        // Ou 

        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }



        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


