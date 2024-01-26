static void Hub()
{
    Console.Clear();
    Console.WriteLine("Seja bem-vindo ao calculador automatico \n 1 - Somar \n 2 - Subtrair \n 3 - Dividir \n 4 - Multiplicar");
    Console.Write("Digite a opcao desejada: ");
    string opcaoSelecionada = Console.ReadLine();
    int opcaoSelecionadaNum = int.Parse(opcaoSelecionada);

    switch (opcaoSelecionadaNum)
    {
        case 1:
            Somar();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Hub();
static void Somar()
{
        Console.Clear();
        float somatorios = 0;
        Console.WriteLine("SOMA");
        Console.Write("Para adicionar um numero a soma, digite somar\nPara sair deste hub, digite sair\n");
        string somarOuSair = Console.ReadLine();

        while(somarOuSair.ToLower() == "somar")
    {
        Console.Write("Digite um numero: ");
        string numeroDigitado = Console.ReadLine();
        float addSomatorio = float.Parse(numeroDigitado);
        somatorios += addSomatorio;
        Console.WriteLine(somatorios);
        Console.Write("Para adicionar um numero a soma, digite somar\nPara sair deste hub, digite sair\n");
        somarOuSair = Console.ReadLine();
    }

    Console.WriteLine("Saindo...");
    Thread.Sleep(1000);
    Hub();

}
