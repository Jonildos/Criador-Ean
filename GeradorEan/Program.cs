using System;

class Program
{
    // Método para calcular o dígito verificador e retornar o código completo
    public static string GerarCodigoEan13(string base12digitos)
    {
        int somaPares = 0;
        int somaImpares = 0;

        // Loop para percorrer os 12 dígitos
        for (int i = 0; i < base12digitos.Length; i++)
        {
            int digito = int.Parse(base12digitos[i].ToString());

            // Posições 0, 2, 4... são as posições ÍMPARES (1ª, 3ª, 5ª...)
            if ((i % 2) == 0)
            {
                somaImpares += digito;
            }
            else // Posições 1, 3, 5... são as posições PARES (2ª, 4ª, 6ª...)
            {
                somaPares += digito;
            }
        }

        // Multiplica a soma dos dígitos pares por 3
        int somaTotal = somaImpares + (somaPares * 3);

        // Calcula o dígito verificador
        int resto = somaTotal % 10;
        int digitoVerificador = (resto == 0) ? 0 : 10 - resto;

        // Retorna o código completo
        return base12digitos + digitoVerificador;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Gerador de Código EAN-13 ---");
        int quantidade;

        while (true)
        {
            Console.Write("Digite a quantidade de códigos EAN-13 a serem gerados: ");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
            {
                break;
            }
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }

        Console.WriteLine($"\n--- Gerando {quantidade} Códigos EAN-13 (Padrão Brasil) ---");

        Random randomGenerator = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            // Define o prefixo do Brasil
            string prefixoBrasil = "789";

            // Gera os próximos 9 dígitos aleatoriamente
            string ean9 = "";
            for (int j = 0; j < 9; j++)
            {
                ean9 += randomGenerator.Next(0, 10).ToString();
            }

            // Junta o prefixo com os dígitos aleatórios para formar a base de 12 dígitos
            string ean12 = prefixoBrasil + ean9;

            // Chama o método que criamos para calcular o código completo
            string codigoCompleto = GerarCodigoEan13(ean12);

            Console.WriteLine(codigoCompleto);
        }
    }
}
