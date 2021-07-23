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
        if (Tag == ConsoleColor.Red) 
        {
            
        }
        else
        {

        }
        return false;
    }
}