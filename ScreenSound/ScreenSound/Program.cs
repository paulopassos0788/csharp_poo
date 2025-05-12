using ScreenSound;

Musica musica1 = new Musica();
musica1.Nome = "Song 1";
musica1.Artista = "Artist 1";
musica1.Duracao = 180;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Song 2";
musica2.Artista = "Artist 2";
musica2.Duracao = 240;
musica2.Disponivel = false;

musica1.ExibirDetalhes();
musica2.ExibirDetalhes();