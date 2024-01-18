using System;
using System.Text;
using System.Threading;

namespace CadastroProduto;

   class Cadastrolista
{
    private static List<Produto> produtos = new List<Produto>();

    public static void Cadastro()
    {
        Console.Clear();
        Console.WriteLine("                 #CADASTRO DE PRODUTOS");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("\n Nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write(" ");
        Console.Write("Preço do produto: ");
        string preco = Console.ReadLine();


        Console.Write(" ");
        Console.Write("Quantidade em estoque: ");
        int Estoque = int.Parse(Console.ReadLine());

        Produto novoProduto = new Produto(nome, Convert.ToDouble(preco), Estoque);
        produtos.Add(novoProduto);
        Console.WriteLine("Produto adicionado com sucesso");
        Thread.Sleep(2500);
        Menu.Show();

    }

    public static void Lista()
    {
        Console.Clear();
        if (produtos.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("                 #CADASTRO DE PRODUTOS");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\nListagem de Produtos");
            foreach (Produto p in produtos)
            {

                Console.WriteLine(p.ObterTexto());
            }

            Console.WriteLine("Pressine qualquer tecla para voltar ao Menu...");
            Console.ReadKey();
            Menu.Show();

        }

        else
        {
            Console.Clear();
            Console.WriteLine("                 #CADASTRO DE PRODUTOS");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\nNão há produtos cadastrados.");
            Thread.Sleep(2500);
            Menu.Show();

        }
    }

}