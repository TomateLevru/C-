using System;

public class exercicio_14
{
    public static void Main(string[] args)
    {
        int resultado = numerofinal(5, 10);
        Console.WriteLine(resultado);

    }

    static int numerofinal (int a, int b)
    {
            
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
            
        
    }
}