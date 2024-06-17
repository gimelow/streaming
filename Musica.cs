class Musica
{
    //construtor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    //um metodo mais conciso com => lambda
    public string DescricaoResumida => $"a música {Nome} pertence a banda {Artista}";
    /*
    public string DescricaoResumida
    {
        get { return $"a música {Nome} pertence a banda {Artista}"; }
    }
    */

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}\n" +
            $"Artista: {Artista.Nome}\n" +
            $"Duração: {Duracao}\n");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else {
            Console.WriteLine("Adquira o plano plus.\n");

        }

    }

 }
