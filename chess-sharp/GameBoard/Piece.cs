using ChessSharp.GameBoard;

namespace ChessSharp.GameBoard
{
    class Piece(Position position, Color color, Table table)
    {
        public Position Position { get; set; } = position;
        public Color Color { get; protected set; } = color;
        public int MovementQuantity { get; set; }
        public Table Table { get; protected set; } = table;
    }
}