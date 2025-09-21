using ChessSharp.GameBoard;

namespace ChessSharp.Chess
{

    public class King : Piece
    {
        public King(Color color, Table tab) : base(color, tab)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}