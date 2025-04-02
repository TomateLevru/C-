using System;
using System.ComponentModel;

public class exercicio21
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> listatelefonica = new Dictionary<string, string>();
        string opcao;

        do
        {
            // menu
            Console.WriteLine(" \nEscolha uma opcção: ");
            Console.WriteLine("1 . Adicionar contato");
            Console.WriteLine("2 .. Pesquisar contato");
            Console.WriteLine("3 ... Remover contato");
            Console.WriteLine("4 ....Sair");

            opcao = Console.ReadLine();
            int opcaoInt2 = Convert.ToInt32(opcao);

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Contacto");
                    string contacto = Console.ReadLine();
                    listatelefonica.Add(nome, contacto);
                    break;

                case "2":

                    Console.WriteLine("Pesquisar contacto:");
                    string pesquisarcontacto = Console.ReadLine();

                    if (listatelefonica.ContainsKey(pesquisarcontacto))
                    {
                        Console.WriteLine($"\nTelefone: {listatelefonica[pesquisarcontacto]}");
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado.");
                    }
                    break;

                case "3":

                    Console.WriteLine("Remover contacto:");
                    pesquisarcontacto = Console.ReadLine();

                    if (listatelefonica.ContainsKey(pesquisarcontacto))
                    {
                        listatelefonica.Remove(pesquisarcontacto);
                        Console.WriteLine("Contacto removido");
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado.");
                    }
                    break;

                case "4":
                    Console.WriteLine("saindo...");
                    opcao = "4";
                    break;
            }

        }
        while (opcao != "4");
    }
}