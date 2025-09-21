// O namespace reflete a estrutura: NomeDoProjeto.NomeDaPasta
namespace ChessSharp.Board
{
    // A classe Position pertence a este namespace
    class Position
    {
        // Propriedades da classe
        public int Row { get; set; }
        public int Column { get; set; }

        // Construtor
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        // Você pode adicionar outros métodos aqui depois, como um ToString() para facilitar a impressão
        public override string ToString()
        {
            return $"{Row}, {Column}";
        }
    }
}