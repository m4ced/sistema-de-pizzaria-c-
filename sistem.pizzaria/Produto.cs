using System;

class Produto
{
    public string nome;
    public double preco;

    public Produto(string nome, double preco)
    {
        this.nome = nome;
        this.preco = preco;
    }

    public virtual void Exibir()
    {
        Console.WriteLine(nome + " - R$ " + preco);
    }
}