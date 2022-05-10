Console.WriteLine("TicTacToes");
Console.ReadLine();


Console.WriteLine("What is the name of player 1?");
string player1 = Console.ReadLine();
Console.WriteLine("What is the name of player 2?");
string player2 = Console.ReadLine();

Console.WriteLine($"{player1} izvelies savu simbolu X vai O ");
string player1Simbol = Console.ReadLine();

if (player1Simbol == "O")
{
    string player2Simbol = "X";
}
else string player2Simbol = "O";

Console.WriteLine($"{player1} simbols ir: {player1Simbol}");
Console.WriteLine($"{player2} simbols ir: {player2Simbol}");




