using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança");

        double investimento = 1000;

        
        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " " + "você tem: " + investimento);

            mes++; // mes = mes + 1 ou mes =+ 1
        }
        */

        for (int mes = 1; mes <= 12; mes++) // Recebe 3 parametros: Variável inicialização, condição a ser respeitada, e nosso contador
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " " + "você tem: " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


