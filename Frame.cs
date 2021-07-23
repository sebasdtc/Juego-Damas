using System;
class Frame
{
    // funcion Dibujar Cuadro
    // Recibe cuatro parametros ancho, altura, posicion X y posicion Y
    public static void DrawFrame(int width, int height, int pX, int pY)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(pX, pY);
        Console.Write("╔");
        for (int col = 0; col < width - 2; col++)
            Console.Write("═");
        Console.Write("╗");
        for (int row = 1; row < height - 1; row++)
        {
            Console.SetCursorPosition(pX, pY + row);
            Console.Write("║");
            for (int i = 1; i < width - 1; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" ");
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("║");
        }
        Console.SetCursorPosition(pX, pY + height - 1);
        Console.Write("╚");
        for (int col = 0; col < width - 2; col++)
            Console.Write("═");
        Console.Write("╝");
        Console.ResetColor();
    }

    // Funcion dibujar linea
    // Recibe como parametro el ancho y las posiciones iniciales
    public static void DrawLine(int width, int pX, int pY)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(pX, pY);
        for (int col = 0; col < width; col++)
            Console.Write("═");
        Console.ResetColor();
    }
}