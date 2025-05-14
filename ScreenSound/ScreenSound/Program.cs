using ScreenSound;

Podcast podcast1 = new Podcast("Podcast 1", "Host 1");

Episodio episodio1 = new Episodio("Episódio 1", "Resumo do episódio 1", 1, 30);
Episodio episodio2 = new Episodio("Episódio 2", "Resumo do episódio 2", 2, 45);
episodio1.AdicionarConvidado(new Convidado("Convidado 1"));
episodio1.AdicionarConvidado(new Convidado("Convidado 2"));
episodio2.AdicionarConvidado(new Convidado("Convidado 3"));
episodio2.AdicionarConvidado(new Convidado("Convidado 4"));

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.ExibirPodcast();


/*
Banda banda1 = new Banda("Banda 1");

Album album1 = new Album("Album 1");

Musica musica1 = new Musica(banda1, "Musica 1")
{
    Duracao = 180,
    Disponivel = true
};

Musica musica2 = new Musica(banda1, "Musica 2")
{
    Duracao = 240,
    Disponivel = false
};

Musica musica3 = new Musica(banda1, "Musica 3")
{
    Duracao = 300,
    Disponivel = true
};

banda1.ExibirDiscografia();

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album1.AdicionarMusica(musica3);
album1.ExibirDetalhes();
*/