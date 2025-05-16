﻿using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    } catch (Exception ex)
    {
        Console.WriteLine($"Erro ao acessar a API. {ex.Message}");
    }

}