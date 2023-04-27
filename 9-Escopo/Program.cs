using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João Está acompanhado!";
        }
        else
        {
            textoAdicional = "João não está acompanhado!";
        }

        if (idadeJoao >= 18 || acompanhado) // Podemos usar o || = Ou    && = E
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não Pode Entrar!");


        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


