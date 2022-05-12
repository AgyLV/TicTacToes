Console.WriteLine("TicTacToes");
Console.ReadLine();


Console.WriteLine("What is the name of player 1?");
string player1 = Console.ReadLine();
Console.WriteLine("What is the name of player 2?");
string player2 = Console.ReadLine();

Console.WriteLine($"{player1} choose your simbol X or O ");
string player1Simbol = Console.ReadLine().ToUpper();


if (player1Simbol == "O")
{
    string player2Simbol = "X";
    Console.WriteLine($"{player1} simbol: {player1Simbol}");
    Console.WriteLine($"{player2} simbol: {player2Simbol}");
}
else if (player1Simbol == "X")
{
    string player2Simbol = "O";
    Console.WriteLine($"{player1} simbol: {player1Simbol}");
    Console.WriteLine($"{player2} simbol: {player2Simbol}");
}

Console.WriteLine("Game Starts!");
Console.ReadLine();


int[] gameBoard = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int choise = 0;


//GameBoard (Vajag uztaisīt kā atsevišķu clasi, ko izsaukt)

Console.WriteLine("         |         |         ");
Console.WriteLine($"    {gameBoard[1]}    |    {gameBoard[2]}    |    {gameBoard[3]}    ");
Console.WriteLine("         |         |         ");
Console.WriteLine("-----------------------------");
Console.WriteLine("         |         |         ");
Console.WriteLine($"    {gameBoard[4]}    |    {gameBoard[5]}    |    {gameBoard[6]}    ");
Console.WriteLine("         |         |         ");
Console.WriteLine("-----------------------------");
Console.WriteLine("         |         |         ");
Console.WriteLine($"    {gameBoard[7]}    |    {gameBoard[8]}    |    {gameBoard[9]}    ");
Console.WriteLine("         |         |         ");


//Player 1 vienmēr sāk, ar šo funkciju pārbaudam kura spelētāja gājiens ir nākamains. Pāra skaitlis - player1 gājiens. Nepāra - player 2 gajiens.

for(int i = 2; i < gameBoard.Length +1; i++)
{
    if(i%2 ==0)
    {
        Console.WriteLine($"{player1} choose your field!");
        choise = Convert.ToInt32(Console.ReadLine());
        
        i++;
    }
    else
        Console.WriteLine($"{player1} choose your field!");
        choise = Convert.ToInt32(Console.ReadLine());
    i++;

}




KOMENTĀRS