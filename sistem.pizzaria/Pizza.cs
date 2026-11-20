using System;

class Pizza : Produto
{
    public string sabor;
    public string tamanho;

    public Pizza(string sabor, string tamanho, double preco)
        : base(sabor, preco)
    {
        this.sabor = sabor;
        this.tamanho = tamanho;
    }

    public override void Exibir()
    {
        Console.WriteLine("Pizza: " + sabor);
        Console.WriteLine("Tamanho: " + tamanho);
        Console.WriteLine("Preço: R$ " + preco);
    }
}