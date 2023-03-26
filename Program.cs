using static TicTacToe;
using static GameBoard;
var game = new TicTacToe();
int number1, number2;


while (!game.board.IsGameOver())
{
    game.board.PrintBoard();
    Console.WriteLine("Ходит: {0}. Введите координату Х: ", game.currentPlayer);
    bool isInteger1 = int.TryParse(Console.ReadLine(), out number1);
    Console.WriteLine("Введите координату Y: ");
    bool isInteger2 = int.TryParse(Console.ReadLine(), out number2);

    //проверка ввода верных координат
    if (isInteger1 && isInteger2 && number1 >= 0 && number1 <= 2 && number2 >= 0 && number2 <= 2)
    {
        game.Play(number1, number2);
    }
    else
    {
        Console.WriteLine("Неверно введены координаты, попробуйте снова. Допустимы цифры: 0, 1, 2");
    }
}

game.board.PrintBoard();

