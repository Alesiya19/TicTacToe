class GameBoard
{
    //Что может находиться в координате
    public enum CellState
    {
        Empty,
        X,
        O
    }
    private int flag = 0;

    private CellState[,] board = new CellState[3, 3];

    public CellState this[int x, int y]
    {
        get { return board[x, y]; }
        set { board[x, y] = value; }
    }


//проверка на конец игры
    public bool IsGameOver()
    {
        // проверка строк
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != CellState.Empty && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return true;
            }
        }

        // проверка столбцов
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] != CellState.Empty && board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                return true;
            }
        }

        // проверка диагоналей
        if (board[0, 0] != CellState.Empty && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return true;
        }

        if (board[2, 0] != CellState.Empty && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
        {
            return true;
        }

        // проверка на пустоту
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (board[x, y] == CellState.Empty)
                {
                    return false;
                }
            }
        }

        // ничья
        flag = -1;
        return true;
    }

//проверка на ничью
    public int isDraw()
    {
        if (flag == -1)
            Console.WriteLine("Ничья!");
        return flag;

    }

//прорисовка игрового поля
    public void PrintBoard()
    {
        //Console.Clear();
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                switch (board[x, y])
                {
                    case CellState.Empty:
                        Console.Write(" ");
                        break;
                    case CellState.X:
                        Console.Write("X");
                        break;
                    case CellState.O:
                        Console.Write("O");
                        break;
                }

                if (x < 2)
                {
                    Console.Write("|");
                }
            }

            Console.WriteLine();

            if (y < 2)
            {
                Console.WriteLine("-----");
            }
        }
    }


}