using System;
using System.Collections.Generic;


public class Exercicio21
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> listaTelefonica = new Dictionary<string, string>();
        string opcao;

        do
        {

            Console.WriteLine("1. Adicionar contactos \n2. Pesquisar contacto \n3. Remover contactos \n4. Sair");
            Console.WriteLine("Escolha uma opção:");
            opcao = Console.ReadLine();
            int opcaoInt = Convert.ToInt32(opcao);
            switch (opcaoInt)
            {
                case 1:
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Contacto:");
                    string contacto = Console.ReadLine();
                    int contactoInt = Convert.ToInt32(contacto);
                    listaTelefonica.Add(nome, contactoInt.ToString());
                    break;

                case 2:
                    Console.WriteLine("Pesquisar contacto:");
                    string pesquisacontacto = Console.ReadLine();

                    if (listaTelefonica.ContainsKey(pesquisacontacto))
                    {
                        Console.WriteLine($"\nTelefone: {listaTelefonica[pesquisacontacto]}");
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Remover contacto:");
                    pesquisacontacto = Console.ReadLine();

                    if (listaTelefonica.ContainsKey(pesquisacontacto))
                    {
                        listaTelefonica.Remove(pesquisacontacto);
                        Console.WriteLine("Contacto removido.");
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    opcao = "4";
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
        while (opcao != "4");

    }
}
