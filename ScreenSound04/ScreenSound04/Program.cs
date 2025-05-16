using System.Text.Json;
using ScreenSound04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        musicas[10].ExibirMusica();
    } catch (Exception ex)
    {
        Console.WriteLine($"Erro ao acessar a API. {ex.Message}");
    }

}