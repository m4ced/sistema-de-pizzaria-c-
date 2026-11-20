using System;
using System.Collections.Generic;

class Program
{
    static List<Produto> pedido = new List<Produto>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== PIZZARIA =====");
            Console.WriteLine("1 - Pedir pizza");
            Console.WriteLine("2 - Pedir bebida");
            Console.WriteLine("3 - Visualizar pedido");
            Console.WriteLine("4 - Finalizar pedido");
            Console.WriteLine("5 - Fechar sistema");

            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    PedirPizza();
                    break;

                case 2:
                    PedirBebida();
                    break;

                case 3:
                    VisualizarPedido();
                    break;

                case 4:
                    FinalizarPedido();
                    break;

                case 5:
                    Console.WriteLine("Sistema encerrado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }

    static void PedirPizza()
    {
        int opcao;
        int tamanhoOpcao;
        string sabor;
        string tamanho;
        double preco;

        Console.WriteLine("\n===== SABORES =====");
        Console.WriteLine("1 - Calabresa");
        Console.WriteLine("2 - Mussarela");
        Console.WriteLine("3 - Portuguesa");
        Console.WriteLine("4 - Frango com Catupiry");
        Console.WriteLine("5 - Quatro Queijos");
        Console.WriteLine("6 - Marguerita");

        Console.Write("\nEscolha o sabor: ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                sabor = "Calabresa";
                break;

            case 2:
                sabor = "Mussarela";
                break;

            case 3:
                sabor = "Portuguesa";
                break;

            case 4:
                sabor = "Frango com Catupiry";
                break;

            case 5:
                sabor = "Quatro Queijos";
                break;

            case 6:
                sabor = "Marguerita";
                break;

            default:
                Console.WriteLine("Sabor inválido!");
                return;
        }

        Console.WriteLine("\n===== TAMANHOS =====");
        Console.WriteLine("1 - Pequena");
        Console.WriteLine("2 - Média");
        Console.WriteLine("3 - Grande");

        Console.Write("\nEscolha o tamanho: ");
        tamanhoOpcao = int.Parse(Console.ReadLine());

        switch (tamanhoOpcao)
        {
            case 1:
                tamanho = "Pequena";
                preco = 30;
                break;

            case 2:
                tamanho = "Média";
                preco = 40;
                break;

            case 3:
                tamanho = "Grande";
                preco = 50;
                break;

            default:
                Console.WriteLine("Tamanho inválido!");
                return;
        }

        pedido.Add(new Pizza(sabor, tamanho, preco));

        Console.WriteLine("\nPizza adicionada ao pedido!");
    }

    static void PedirBebida()
    {
        int opcao;

        Console.WriteLine("\n===== BEBIDAS =====");
        Console.WriteLine("1 - Coca-Cola 2L - R$ 12");
        Console.WriteLine("2 - Guaraná 2L - R$ 10");
        Console.WriteLine("3 - Suco 500ml - R$ 7");
        Console.WriteLine("4 - Água 500ml - R$ 4");

        Console.Write("\nEscolha sua bebida: ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                pedido.Add(new Bebida("Coca-Cola", "2L", 12));
                break;

            case 2:
                pedido.Add(new Bebida("Guaraná", "2L", 10));
                break;

            case 3:
                pedido.Add(new Bebida("Suco", "500ml", 7));
                break;

            case 4:
                pedido.Add(new Bebida("Água", "500ml", 4));
                break;

            default:
                Console.WriteLine("Bebida inválida!");
                return;
        }

        Console.WriteLine("\nBebida adicionada ao pedido!");
    }

    static void VisualizarPedido()
    {
        double total = 0;

        Console.WriteLine("\n===== SEU PEDIDO =====");

        if (pedido.Count == 0)
        {
            Console.WriteLine("Nenhum produto no pedido.");
            return;
        }

        foreach (Produto produto in pedido)
        {
            Console.WriteLine("--------------------");
            produto.Exibir();

            total += produto.preco;
        }

        Console.WriteLine("--------------------");
        Console.WriteLine("TOTAL: R$ " + total);
    }

    static void FinalizarPedido()
    {
        if (pedido.Count == 0)
        {
            Console.WriteLine("\nNenhum produto para finalizar.");
            return;
        }

        Console.WriteLine("\n===== PEDIDO FINALIZADO =====");

        VisualizarPedido();

        Console.WriteLine("\nObrigado pela preferência!");

        pedido.Clear();
    }
}