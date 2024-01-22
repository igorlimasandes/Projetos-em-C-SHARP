List<string> listaDeMusicas = new List<string>();

void exibirFuncoes()
{
    Console.Clear();
    Console.WriteLine("Digite uma das opcoes abaixo:");
    Console.WriteLine("Digite 1 para ver a lista");
    Console.WriteLine("Digite 2 para adicionar um item a lista");
    Console.WriteLine("Digite 3 para remover um item da lista");
    Console.Write("Acao para realizar: ");
    string acao = Console.ReadLine();
    int acaoNumerica = int.Parse(acao);

    switch (acaoNumerica)
    {
        case 1: exibirLista();
        break;
        case 2: adicionarItem();
        break;
        case 3: deletarItem();   
        break;
    }
}

exibirFuncoes();

void exibirLista()
{
    Console.Clear();
    if(listaDeMusicas.Count > 0)
    {
        listaDeMusicas.ForEach(musicas => Console.WriteLine(musicas));
    } else
    {
        Console.WriteLine("Nenhuma musica encontrada");
    }
    Console.Write("Para voltar digite 1: ");
    string number = Console.ReadLine();
    int intNumber = int.Parse(number);
    if(intNumber == 1)
    {
        exibirFuncoes();
    } 
}

void adicionarItem()
{
    Console.Clear();
    Console.WriteLine("Adicionando musicas");
    Console.Write("Digite a musica que deseja adicionar: ");
    string musicaParaAdicionar = Console.ReadLine();
    if (listaDeMusicas.Contains(musicaParaAdicionar))
    {
        Console.WriteLine("Essa musica ja existe na lista");
        Thread.Sleep(1000);
        exibirFuncoes();
    } else
    {
        listaDeMusicas.Add(musicaParaAdicionar);
        Console.WriteLine(musicaParaAdicionar + " adicionada com sucesso!");
        Thread.Sleep(1000);
        exibirFuncoes();
    }
}

void deletarItem()
{
    Console.Clear();
    Console.WriteLine("Deletando musicas");
    Console.Write("Digite a musica que deseja deletar: ");
    string musicaParaDeletar = Console.ReadLine();
    if (listaDeMusicas.Contains(musicaParaDeletar))
    {
        listaDeMusicas.Remove(musicaParaDeletar);
        Console.WriteLine(musicaParaDeletar + " deletada com sucesso!");
        Thread.Sleep(1000);
        exibirFuncoes();
    }
    else
    {
        Console.WriteLine("A musica que voce digitou nao existe");
        Thread.Sleep(1000);
        exibirFuncoes(); 
    }
}

