using ChessSharp.GameBoard;

namespace ChessSharp.GameBoard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementQuantity { get; set; }

    }
}