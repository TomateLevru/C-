using System;
    
    public class exemplo_metodo
{
    public static void main(string[] args)
    {
        int resultado = Soma(5, 10);

        Console.WriteLine("A soma é: " + resultado);
    }


    // metodo soma a ser usado no método main

    static int Soma(int a, int b)
    {
        return a + b;
    }
}
    