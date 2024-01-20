using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProduto;

class Menu
{
    public static void Show()
    {

        Console.Clear();
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("");
        Console.WriteLine("1 - Cadastrar produtos");
        Console.WriteLine("2 - Lista de produtos");
       // Console.WriteLine("3 - Comprar");
        Console.WriteLine("0- Sair");

        Console.Write("Opção desejada: ");
        string comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();




        switch (comandoEscolhido)
        {
            case "1": Cadastrolista.Cadastro(); break;
            case "2": Cadastrolista.Lista(); break;
            // case "3": Comprar.Comprando(); break;


            case "0":
                Console.Clear();
                Console.WriteLine("                 #CADASTRO DE PRODUTOS");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("\nObrigado por usar o programa.");
                break;
            default:
                Console.WriteLine("\nOpção invalida! tente novamente");
                break;
        }



    }
}
