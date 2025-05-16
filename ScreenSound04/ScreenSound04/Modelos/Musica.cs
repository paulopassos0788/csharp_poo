using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set;}

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
        
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
        
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    
    public void ExibirMusica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao / 1000} ms");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
