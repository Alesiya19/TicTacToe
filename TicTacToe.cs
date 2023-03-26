using static GameBoard;

class TicTacToe
{
    public GameBoard board = new GameBoard();
    public CellState currentPlayer = CellState.X;

    public void Play(int x, int y)
    {

        if (board[x, y] != CellState.Empty)
        {
            Console.WriteLine("Эта координата уже занята, выберите другую");
            return;
        }
            
        board[x, y] = currentPlayer;

        if (board.IsGameOver())
        {
            if(board.isDraw() != -1)
            {
                Console.WriteLine("Игра закончена! {0} выиграли.", currentPlayer);
                return;
            }
        }
        
        currentPlayer = currentPlayer == CellState.X ? CellState.O : CellState.X;
    }

}