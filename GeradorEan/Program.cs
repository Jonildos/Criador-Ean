using System;
using GeradorEan.Services;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Gerador de Código EAN-13 ---");
        Console.Write("Digite o número de códigos EAN desejados: ");
        string EanCode = Console.ReadLine();
        int quantidade = int.Parse(EanCode);

        Console.WriteLine("Gerando " + EanCode + " Códigos Ean.");
    }
}