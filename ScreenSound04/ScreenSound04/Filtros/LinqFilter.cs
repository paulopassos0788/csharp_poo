using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

public class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas
            .Select(genero => genero.Genero).Distinct().ToList();

        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"-> {genero}");
        }
    }

    public static void FiltrarArtistasPorGenerosMusicas(List<Musica> musicas, string genero)
    {
        var artistasPorGeneros = musicas
            .Where(musica => musica.Genero.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero: {genero}");

        foreach (var artista in artistasPorGeneros)
        {
            Console.WriteLine($"-> {artista}");
        }
    }

    public static void FiltraMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtitsta = musicas
            .Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"\nNome do artista: {artista}");

        foreach (var musica in musicasDoArtitsta)
        {
            Console.WriteLine($"-> {musica.Nome}");
        }
    }
    
    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}