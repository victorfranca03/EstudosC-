using System;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int Velocidade { get; private set; }

    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Velocidade = 0;
    }

    public void Acelerar(int incremento)
    {
        Velocidade += incremento;
        Console.WriteLine($"O carro acelerou para {Velocidade} km/h.");
    }

    public void Frear(int decremento)
    {
        Velocidade -= decremento;
        if (Velocidade < 0)
        {
            Velocidade = 0;
        }
        Console.WriteLine($"O carro desacelerou para {Velocidade} km/h.");
    }

    public void Buzinar()
    {
        Console.WriteLine("Buzina: BIP BIP!");
    }
}

class Program
{
    static void Main()
    {
        Carro meuCarro = new Carro("Toyota", "Corolla", 2020);
        meuCarro.Acelerar(30);
        meuCarro.Frear(10);
        meuCarro.Buzinar();
    }
}
