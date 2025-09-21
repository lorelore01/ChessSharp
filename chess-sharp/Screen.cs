using ChessSharp.GameBoard;

namespace ChessSharp
{
    class Screen
    {
        public static void PrintTable(Table tab)
        {
            for (int i = 0; i < tab.Row; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Column; j++)
                {
                    if (tab.GetPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.GetPiece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");

        }
    }
}