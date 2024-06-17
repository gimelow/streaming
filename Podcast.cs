public class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {this.Host}\n" +
            $"Podcast: {this.Nome}\n");
        Console.WriteLine("Episódios");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem)) {
            episodio.ResumoEpisodio();
        }
        Console.WriteLine($"Total de Episódios: {this.TotalEpisodios}\n");

    }
}