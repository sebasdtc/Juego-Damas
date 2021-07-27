using System;

class Player
{
    public string Name { get; set; }

    public ConsoleColor Tag { get; set; }

    public int PosX { get; set; }

    public int PosY { get; set; }

    public bool SelectPiece(int row, int col)
    {
        if ( Tag == Board.GetPiece(row, col).Color )
        {
            PosX = col;
            PosY = row;
            Board.GetPiece(row, col).Background = ConsoleColor.Yellow;
            return true;
        }
        return false;
    }

    public bool MovePiece(int row, int col)
    {
        if (Board.GetPiece(row, col).Color != ConsoleColor.Black) return false;
        
        int dRow = Math.Abs(row - PosY);
        int dCol = Math.Abs(col - PosX);
        
        if (dRow != dCol) return false;

        // comprueba si la pieza es una reina
        if (Board.GetPiece(row, col).TypePiece == " Y ")
        {
            // Comprueba si existe piezas en todo el camino que sean de su mismo tipo
            // en caso de haber no puede moverse
            if (Board.NumberPieces(PosX, PosY, row, col, Board.GetPiece(row, col).Color) != 0) return false;
            
            // Comprueba si existe piezas en todo el camino que sean del tipo contrario
            // en caso de haber no puede moverse
            if (Board.NumberOfOpposingPieces(PosX, PosY, row, col, Board.GetPiece(row, col).Color) >= 1) return false;

        }
        // comprobaciones para piezas normales
        else
        {
            if (dRow > 2) return false;

            if ((Board.GetPiece(row, col).Color == ConsoleColor.Red) && (col < PosY)) return false;
            
            if ((Board.GetPiece(row, col).Color == ConsoleColor.White) && (col > PosY)) return false;

            // Comprueba el caso para cuando se desplaza dos casilleros no existe una pieza contraria
            // de ser asi retorna falso
            if (dRow == 2) 
                if (Board.NumberOfOpposingPieces(PosX, PosY, row, col, Board.GetPiece(row, col).Color) == 0)
                    return false;
        }
        return true;
    }
}