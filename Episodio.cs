public class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo { get; set; }


    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

    public void ResumoEpisodio()
    {
        string listaConvidados = string.Join(", ", convidados);
        Console.WriteLine($"{this.Ordem} - Título: {this.Titulo}\n" +
                $"Resumo: {this.Resumo}\n" +
                $"Duração: {this.Duracao} minutos\n" +
                $"Convidados: {listaConvidados}\n");
    }
}