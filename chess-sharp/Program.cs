using ChessSharp.GameBoard;
using ChessSharp.Chess;

namespace ChessSharp
{
    class Program
    {
        static void Main(string[] args)
        {



            Table tab = new Table(8, 8);


            Position kingPosition = new Position(5, 5);

            King blackKing = new King(Color.Black, tab);

            tab.SetPiece(blackKing, kingPosition.Row, kingPosition.Column);

            Screen.PrintTable(tab);

        }

    }



}