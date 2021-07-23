using System;

class Piece
{
    // Representa la pieza del juego
    // Por defecto sera una pieza comun representada por 'O'
    private string _typePiece;

    // Dara el color a la pieza Blanco y Rojo.
    // Servira tambien como identificador para los jugadores.
    private ConsoleColor _color;

    // Sirve para hacer contraste con el fondo del tablero.
    private ConsoleColor _background;

    public Piece()
    {
        _typePiece = " O ";
        _color = ConsoleColor.White;
        _background = ConsoleColor.White;
    }

    public string TypePiece
    {
        get => _typePiece;
    }

    public ConsoleColor Color
    {
        get => _color;
        set => _color = value;
    }

    public ConsoleColor Background
    {
        get => _background;
        set => _background = value;
    }

    public void Show()
    {
        Console.BackgroundColor = _background;
        Console.ForegroundColor = _color;
        Console.Write(_typePiece);
        Console.ResetColor();
    }

    // Funcion borrar pieza.
    // Con el color black asignado hara el efecto de que se ha eliminado la pieza.
    public void DeletePiece()
    {
        _color = ConsoleColor.Black;
        _background = ConsoleColor.Black;
    }
}