﻿using System;

public class exercicio17
{
    public static void Main(String[] args)
    {
        // array para uma lista de filmes
        String[] listadefilmes = { "hary poter", "Zorro", "Simpsons" };
        // segundo array para o ano dos filmes
        int[] anodofilme = { 1990, 2010, 2014 };
        Console.WriteLine("lista de filmes");
        Console.WriteLine();

        
        for (int contador = 0; contador < anodofilme.Length; contador++)
        {
            Console.WriteLine($"{listadefilmes[contador]} - {anodofilme[contador]}");
        }




    }
}
