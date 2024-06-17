//instancia da classe Banda
Banda metallica = new("Metallica");
Banda aliceInChains = new("Alice in Chains");

//instancia da classe Album
Album masterOfPuppets = new("Master of Puppets");
Album dirt = new("Dirt");

//instancia da classe Musica
Musica musica1 = new(metallica, "Battery")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new(metallica, "Master of Puppets")
{
    Duracao = 368,
    Disponivel = false,
};

Musica musica3 = new(aliceInChains, "Would?")
{
    Duracao = 328,
    Disponivel = false,
};

masterOfPuppets.AdicionarMusica(musica1);
masterOfPuppets.AdicionarMusica(musica2);
metallica.AdicionarAlbum(masterOfPuppets);

dirt.AdicionarMusica(musica3);
aliceInChains.AdicionarAlbum(dirt);

//instancia da classe Podcast
Podcast podcast1 = new("Giovanna Melo", "Pod C#");

//instacia da classe Episodio
Episodio episodio1 = new(2, "C# na teoria", 100)
{
    Resumo = "Como aprender C#"
};

Episodio episodio2 = new(1,"C# na prática", 100)
{
    Resumo = "Como aplicar C#"
};

episodio1.AdicionarConvidados("Maria");
episodio2.AdicionarConvidados("Jósé");
episodio2.AdicionarConvidados("João");

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

//prints na tela/testes
Console.WriteLine("FICHA TÉCNICA - MÚSICAS");
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine($"MÚSICAS DO ÀLBUM - {masterOfPuppets.Nome}");
masterOfPuppets.ExibirMusicasDoAlbum();

Console.WriteLine($"DISCOGRAFIA - {metallica.Nome}");
metallica.ExibirDiscografia();

Console.WriteLine($"PODCAST - {podcast1.Nome}");
podcast1.ExibirDetalhes();

