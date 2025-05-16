using System.Text.Json;

namespace ScreenSound04.Modelos;

public class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> Musicas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public void AdicionarMusicas(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicasFavoristas()
    {
        Console.WriteLine($"\nEssas sao as musicas favoritas -> {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = Musicas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo json gerado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
    }
}