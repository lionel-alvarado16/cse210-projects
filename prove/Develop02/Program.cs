using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        List<string> lista = new List<string> {"manzana", "naranja", "pera", "uva"};
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(lista.Count);
        string prompt = lista[index];

        Console.WriteLine(prompt);
    }
}