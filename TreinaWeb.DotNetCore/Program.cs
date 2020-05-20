using System;

namespace Treinaweb.DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Olá, {nome}");
            Console.WriteLine($"Você tem, {idade} anos");
        }
    }
}
