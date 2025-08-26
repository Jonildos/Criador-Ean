using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Gerador de Código EAN-13 ---");
        int quantidade;

        while(true)
        {
            Console.Write("Digite a quantidade de códigos EAN-13 a serem gerados: ");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
            {
                break;
            }
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }


    }
}