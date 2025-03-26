using System;

public class exercicio20
{
    public static void Main(string[] args)
    {
        long numeroGrande = 1234567890;

        int num = Convert.ToInt32(numeroGrande);

        double valorDecimal = 250.35; 
        int valorInteiro = Convert.ToInt32(valorDecimal);

        Console.WriteLine($"Numero Decimal = '{valorDecimal}' Numero inteiro = '{valorInteiro}'");

        char letras = 'V';
        int numLetra = (letras);

        Console.WriteLine($"Letra = '{letras}' letra para o ASCII = '{numLetra}'");

        int megabyte = 300;
        byte supermegabyte = (byte)megabyte;

        Console.WriteLine($"Numero maior que um byte = '{megabyte}' numero byte = '{supermegabyte}'");

        double numerolongistico = 6946539579.9843589;
        float numeronaolongo = (float)numerolongistico;

        Console.WriteLine($"numero maior = '{numerolongistico}' numero menor = '{numeronaolongo}'");
    }
}
