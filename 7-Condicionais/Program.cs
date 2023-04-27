using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele Está acompanhado pode entrar");
            }
            else
            {
                Console.WriteLine("Não Pode Entrar!");
            }

        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


