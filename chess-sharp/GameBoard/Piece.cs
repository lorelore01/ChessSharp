using ChessSharp.GameBoard;

namespace ChessSharp.GameBoard
{
    public class Piece(Color color, Table table)
    {
        public Position Position { get; set; } = null;
        public Color Color { get; protected set; } = color;
        public int MovementQuantity { get; set; }
        public Table Table { get; protected set; } = table;
    }
}