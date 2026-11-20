using System;

class Bebida : Produto
{
    public string volume;

    public Bebida(string nome, string volume, double preco)
        : base(nome, preco)
    {
        this.volume = volume;
    }

    public override void Exibir()
    {
        Console.WriteLine("Bebida: " + nome);
        Console.WriteLine("Volume: " + volume);
        Console.WriteLine("Preço: R$ " + preco);
    }
}