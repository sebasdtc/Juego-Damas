using System;

namespace clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "JUEGO DE DAMAS";
            Frame.DrawFrame(80, 22, POS_INI_X - 3, POS_INI_Y - 3);
            Frame.DrawFrame(31, 12, POS_INI_X, POS_INI_Y);
            Frame.DrawLine(78, LINE_INI_X, LINE_INI_Y);
            Board.InitBoard();
            Board.Show(POS_INI_X + 2, POS_INI_Y + 1);
            ErrorMessage("Opcion invalida");
            Console.ReadKey();
            Console.Clear();
        }

        // Constantes que indican las posiciones iniciales del tablero.
        public const int POS_INI_X = 4;
        public const int POS_INI_Y = 4;
        public const int LINE_INI_X = 2;
        public const int LINE_INI_Y = 20;
        
        // metodo para mostrar mensaje de error, tiene una posicion definida para el juego
        public static void ErrorMessage(string txt)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(LINE_INI_X, LINE_INI_Y + 1);
            // Formato para que se resalte mejor el mensaje de error.
            Console.WriteLine(String.Format("{0,-78:D}", "Error: " + txt));
            Console.ResetColor();
        }
    }
}