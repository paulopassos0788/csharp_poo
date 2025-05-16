using System.Text.Json;
using ScreenSound04.Filtros;
using ScreenSound04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //musicas[0].ExibirMusica();
        
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenerosMusicas(musicas, "rock");
        //LinqFilter.FiltraMusicasDeUmArtista(musicas, "Michel Teló");

        // var musicasPreferidas = new MusicasPreferidas("Paulo");
        // musicasPreferidas.AdicionarMusicas(musicas[6]);
        // musicasPreferidas.AdicionarMusicas(musicas[1]);
        // musicasPreferidas.AdicionarMusicas(musicas[2]);
        // musicasPreferidas.AdicionarMusicas(musicas[50]);
        // musicasPreferidas.AdicionarMusicas(musicas[40]);
        //
        // musicasPreferidas.ExibirMusicasFavoristas();
        //
        // musicasPreferidas.GerarArquivoJson();
    } catch (Exception ex)
    {
        Console.WriteLine($"Erro ao acessar a API. {ex.Message}");
    }

}