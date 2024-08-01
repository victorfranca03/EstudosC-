Album albumDoTauz = new Album();
albumDoTauz.Nome = "Anime";

Musica musica1 = new Musica();
musica1.Nome = "Alucard";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Barba Branca";
musica2.Duracao =223;

albumDoTauz.AdicionarMusica(musica1);
albumDoTauz.AdicionarMusica(musica2);

albumDoTauz.ExibirMusicasDoAlbum();