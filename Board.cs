using System;

class Board
{
    // Creacion de la matriz que hara de tablero del juego
    private static Piece[,] board = new Piece[8, 8];

    // Constructor, llena la matriz con valores:
    public static void InitBoard()
    {
        // -1 color amarillo del tablero
        //  0 color rojo del tablero, representa tambien las posicion donde iran las piezas
        for (int row = 0; row < 8; row++)
            for (var col = 0; col < 8; col++)
            {
                Piece emptyPiece = new Piece();
                board[row, col] = emptyPiece;
                if ((row + col) % 2 == 1)
                    board[row, col].DeletePiece();
            }

        //  2 posicion para las piezas del primer jugador
        for (int row = 0; row < 3; row++)
            for (var col = 0; col < 8; col++)
                if ((row + col) % 2 == 1)
                    board[row, col].Color = ConsoleColor.Red;

        //  1 posicion para las piezas del segundo jugador
        for (int row = 5; row < 8; row++)
            for (var col = 0; col < 8; col++)
                if ((row + col) % 2 == 1)
                    board[row, col].Color = ConsoleColor.White;
    }

    // Funcion para mostrar el tablero de juego
    public static void Show(int pX, int pY)
    {
        /* C variable que indica las columnas del tablero */
        char c = 'A';

        /* Imprime las letras que representan las columnas */
        Console.SetCursorPosition(pX + 2, pY);
        // Colores predeterminado para el fondo y el texto del cuadro.
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        for (int col = 0; col < 8; col++)
            Console.Write($" {c++} ");

        /* Imprime el tablero con colores */
        for (int row = 0; row < 8; row++)
        {
            Console.SetCursorPosition(pX, pY + row + 1);
            Console.Write($"{row + 1} ");
            // muestra el objeto piece
            for (int col = 0; col < 8; col++)
                board[row, col].Show();
            Console.WriteLine();
            // Colores predeterminado para el fondo y el texto del cuadro.
            // Se aplica debido a que el metodo Show tiene un ResetColor.
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

    // Funcion para obtener la pieza de una posicion dada de la matriz
    public static Piece GetPiece(int row, int col) { return board[row, col]; }

    // Funcion para comprobar cuantas piezas hay de un tipo dado en toda una diagonal
    // recible 2 parametros posiciones iniciales y 2 parametros hasta donde recorre y un parametro del tipo a buscar
    public static int NumberPieces(int rowInit, int colInit, int rowEnd, int colEnd, ConsoleColor tag)
    {
        int count = 0, i = 0, j = 0;
        if (rowEnd - rowInit >= 0) i = 1;
        else i = -1;
        if (colEnd - colInit >= 0) j = 1;
        else j = -1;
        for (int row = rowInit, col = colInit; row < rowEnd && col < colEnd; row += i, col += j)
            if (board[row, col].Color == tag) count++;

        return count;
    }

    // Funcion para comprobar cuantas piezas hay de un tipo dado en toda una diagonal
    // recible 2 parametros posiciones iniciales y 2 parametros hasta donde recorre y un parametro del tipo a buscar    
    public static int NumberOfOpposingPieces(int rowInit, int colInit, int rowEnd, int colEnd, ConsoleColor tag)
    {
        int count = 0, i = 0, j = 0;
        if (rowEnd - rowInit >= 0) i = 1;
        else i = -1;
        if (colEnd - colInit >= 0) j = 1;
        else j = -1;
        for (int row = rowInit, col = colInit; row < rowEnd && col < colEnd; row += i, col += j)
            if (board[row, col].Color != tag && board[row, col].Color != ConsoleColor.Black) count++;

        return count;
    }

}//class Board