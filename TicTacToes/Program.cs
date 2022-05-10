Console.WriteLine("TicTacToes");
Console.ReadLine();


Console.WriteLine("What is the name of player 1?");
string player1 = Console.ReadLine();
Console.WriteLine("What is the name of player 2?");
string player2 = Console.ReadLine();

Console.WriteLine($"{player1} choose your simbol X or O ");
string player1Simbol = Console.ReadLine();

if (player1Simbol == "O")
{
    string player2Simbol = "X";
}
else string player2Simbol = "O";

Console.WriteLine($"{player1} simbol: {player1Simbol}");
Console.WriteLine($"{player2} simbol: {player2Simbol}");




