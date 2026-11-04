Console.WriteLine("Pedra, Papel ou Tesoura?");
string jogador = Console.ReadLine();
Console.WriteLine("Você Jogou:" + jogador);
Random sorteio = new Random();
int numero = sorteio.Next(0, 3);
Console.WriteLine("O Computador Jogou:" + numero);
Console.ReadLine();