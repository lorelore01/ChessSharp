using ChessSharp.GameBoard;

namespace ChessSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Position pos = new Position(3, 4);
            Console.WriteLine(pos.Row);
            Console.WriteLine($"As coordenadas são ({pos.ToString()})");
            Table tab = new Table(8, 8);
            Screen.PrintTable(tab);
        }

    }



}