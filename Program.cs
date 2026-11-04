int pontosJogador = 0;
int pontosComputador = 0;
Random sorteio = new Random();

while (pontosJogador < 3 && pontosComputador < 3)
{
    Console.WriteLine("Pedra, papel ou tesoura?");
    string jogador = Console.ReadLine();
    jogador = jogador.ToLower();

    int numero = sorteio.Next(0, 3);

    // JOGADAS
    string computador;
    if (numero == 0)
    {
        computador = "pedra";
    }
    else if (numero == 1)
    {
        computador = "papel";
    }
    else
    {
        computador = "tesoura";
    }

    Console.WriteLine("Você jogou: " + jogador);
    Console.WriteLine("O computador jogou: " + computador);

    // RESULTADOS
    if (jogador == computador)
    {
        Console.WriteLine("Empate!");
    }
    else if (jogador == "pedra" && computador == "tesoura")
    {
        pontosJogador++;
        Console.WriteLine("Você ganhou!");
    }
    else if (jogador == "papel" && computador == "pedra")
    {
        pontosJogador++;
        Console.WriteLine("Você ganhou!");
    }
    else if (jogador == "tesoura" && computador == "papel")
    {
        pontosJogador++;
        Console.WriteLine("Você ganhou!");
    }
    else
    {
        pontosComputador++;
        Console.WriteLine("O computador ganhou!");
    }

    Console.WriteLine("Placar: Você " + pontosJogador + " x " + pontosComputador + " Computador");
    Console.WriteLine();
}

if (pontosJogador == 3)
{
    Console.WriteLine("Você venceu o jogo!");
}
else
{
    Console.WriteLine("O computador venceu o jogo!");
}

Console.ReadLine();