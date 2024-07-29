//NOME
//ARTISTA
//DURACAO
//DISPONIVEL
class Musica
{
   public string Nome {  get; set; }
   public string Artista { get; set; }
   public int Duracao { get; set; }
   public bool Dispoivel {  get; set; } // set(escreve) // get(lê)
    public string DescricaoResumida => $"A musica {Nome} pertence á banda {Artista}";
                                    //Função Lambda usada para tratar apenas do get (que se trata da leitura da propriedade)



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Dispoivel) 
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+");
        }

    }
}

