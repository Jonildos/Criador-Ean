using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de códigos EAN desejados: ");
            string EanCode = Console.ReadLine();    
            int quantidade = int.Parse(EanCode);

            Console.Writeline("Gerando " + EanCode + " Códigos Ean.")
    }
    }