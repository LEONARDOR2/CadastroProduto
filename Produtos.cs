using System;
using System.Text;

namespace CadastroProduto;

class Produto
{
    private string nome;

    public string Nome
    {

        get { return nome; }
        set
        {
            if (value.Length > 1)
                nome = value;

            else
                throw new Exception("Nome do produto deve ter pelo menos 2 caracteres ");

        }
    }

    public double Preco { get; set; }

    public int Estoque { get; private set; }


    public Produto(string nome, double preco, int estoque)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Estoque = estoque;
    }
    public int Vender(int qtde)
    {
        if (this.Estoque - qtde >= 0)
            this.Estoque -= qtde;

        return this.Estoque;
    }
    public int Comprar(int qtde)
    {
        this.Estoque += qtde;
        return this.Estoque;
    }

    public string ObterTexto()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"\nNome: {this.Nome}\n");
        sb.Append($"\nPreço: R$ {this.Preco:F2}\n");
        sb.Append($"\nEstoque: {this.Estoque}\n");
        return sb.ToString();
    }


}

