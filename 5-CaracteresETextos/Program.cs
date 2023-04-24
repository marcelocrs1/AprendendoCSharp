using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a'; // Caracteres precisam estar em aspas simples isso é importante
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);
        Console.WriteLine(letra);


        char[] chars = { 'a', 'b', 'c', }; //Array de Caracteres
        Console.WriteLine(chars);

        string nome = "Marcelo";
        Console.WriteLine(nome);

        string[] nomes = { "Marcelo", "Daniel", "Jorge", };
        Console.WriteLine(nomes[1]);

        string cursos = @"Cursos Disponíveis:
- GO
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}


