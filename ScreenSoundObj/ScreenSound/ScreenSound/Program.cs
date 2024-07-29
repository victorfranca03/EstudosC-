Musica musica1 =  new Musica();
musica1.Nome = "November Rain";
musica1.Artista = "Guns 'N  Roses";
musica1.Duracao = 273;
musica1.Dispoivel = true;
Console.WriteLine(musica1.DescricaoResumida);



Musica musica2 = new Musica();
musica2.Nome = "StarBoy";
musica2.Artista = "The Wekend";
musica2.Duracao = 299;
musica2.Dispoivel = false;
Console.WriteLine(musica2.DescricaoResumida);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
