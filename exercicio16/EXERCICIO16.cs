using System;



public class Exercicio16
{
    private static int valor1;

    public static void Main(string[] args)
    {
        parimpar(10);//testa numero par
        parimpar(11);//testa numero impar
    }

    public static void parimpar(int valor1)
    {

        bool resultado = valor1 % 2 == 0;
        if (resultado)
        {
            quadradoNumPar(valor1);


        }
        else
        {
            Console.WriteLine("o numero nao e par e por isso nao nao e calculado o valor ao quadrado");



        }
    }
    //Metodo para saber o quadrado 
    public static void quadradoNumPar(int valor2)
    {
        int resultado = valor2 * valor2;
        Console.WriteLine("O quadrado do valor " + valor2 + " é " +
            + resultado);


    }
}