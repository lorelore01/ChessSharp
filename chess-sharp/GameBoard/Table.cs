using ChessSharp.GameBoard;


namespace ChessSharp.GameBoard
{

    public class Table
    {
        public int Row { get; set; }
        public int Column { get; set; }
        private readonly Piece[,] pieces;

        public Table(int row, int column)
        {
            Row = row;
            Column = column;
            pieces = new Piece[row, column];
        }

        public Piece GetPiece(int row, int column)
        {
            return pieces[row, column];
        }


        public Piece GetPiece(Position pos)
        {
            return pieces[pos.Row, pos.Column];
        }


        public void SetPiece(Piece piece, int row, int column)
        {
            pieces[row, column] = piece;

        }



    }



}
