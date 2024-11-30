Album albumDoTauz = new Album();
albumDoTauz.Nome = "Anime";

Musica musica1 = new Musica(tuaz);
musica1.Nome = "Alucard";
musica1.Duracao = 213;


Musica musica2 = new Musica(tauz2);
musica2.Nome = "Barba Branca";
musica2.Duracao =223;

albumDoTauz.AdicionarMusica(musica1);
albumDoTauz.AdicionarMusica(musica2);

Banda playerTauz = new Banda();
playerTauz.Nome = "playerTauz";
playerTauz.AdicionarAlbum(albumDoTauz);
playerTauz.ExibirDiscografia();