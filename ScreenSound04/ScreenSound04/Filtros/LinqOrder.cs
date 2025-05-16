using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

public class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenadas = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("\nLista de artistas ordenadas");
        foreach (var artista in artistasOrdenadas)
        {
            Console.WriteLine($"-> {artista}");
        }
    }
}