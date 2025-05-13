using ScreenSound;

Album album = new Album();
album.Name = "Nevermind";

Genero genero1 = new Genero();
genero1.Nome = "Grunge";

Musica musica2= new Musica();
musica2.Nome = "Smells Like Teen Spirit";
musica2.Artista = "Nirvana";
musica2.Duracao = 301;
musica2.Disponivel = true;

Musica musica4 = new Musica();
musica4.Nome = "Come As You Are";
musica4.Artista = "Nirvana";
musica4.Duracao = 219;
musica4.Disponivel = true;

Musica musica5 = new Musica();
musica5.Nome = "Lithium";
musica5.Artista = "Nirvana";
musica5.Duracao = 257;
musica5.Disponivel = true;

Musica musica6 = new Musica();
musica6.Nome = "In Bloom";
musica6.Artista = "Nirvana";
musica6.Duracao = 254;
musica6.Disponivel = true;

musica2.ExibirDetalhes();
musica4.ExibirDetalhes();
musica5.ExibirDetalhes();
musica6.ExibirDetalhes();

album.AdicionarMusica(musica2);
album.AdicionarMusica(musica4);
album.AdicionarMusica(musica5);
album.AdicionarMusica(musica6);

album.ExibirDetalhes();
genero1.AdicionarMusica(musica2);
genero1.AdicionarMusica(musica4);
genero1.AdicionarMusica(musica5);
genero1.ExibirDetalhes();

