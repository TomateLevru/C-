using System;

public class arraytest
{
    public static void Main(string[] args)
    {
        int[] idadealunos = {10, 15, 17, 19 };
        Console.WriteLine("idade percorrida com for: ");
        for (int contador = 0; contador < idadealunos.Length; contador++);
        {
            Console.WriteLine(idadealunos[1]);
        }


        Console.WriteLine("idade percorrida com foreach: ");
        foreach (int idade in idadealunos);
        {
            Console.WriteLine(idade);
        }

    }
}