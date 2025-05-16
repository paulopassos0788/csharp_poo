using System.Text.Json;
using ScreenSound04.Filtros;
using ScreenSound04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenerosMusicas(musicas, "rock");
        LinqFilter.FiltraMusicasDeUmArtista(musicas, "Michel Teló");
    } catch (Exception ex)
    {
        Console.WriteLine($"Erro ao acessar a API. {ex.Message}");
    }

}