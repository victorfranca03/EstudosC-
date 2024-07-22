//NOME
//ARTISTA
//DURACAO
//DISPONIVEL
class Musica
{
   public string nome;
   public string artista;
   public int duracao;
   public bool dispoivel;

   public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista:{artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (dispoivel) 
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+");
        }

    }
}

