namespace ChessLogic.Moves
{
    public class NormalMove : Move
    {
        public override MoveType Type => MoveType.Normal;
        public override Position FromPos { get; }
        public override Position ToPos { get; }

        public NormalMove(Position from, Position to)
        {
            FromPos = from;
            ToPos = to;
        }

        public override bool Execute (Board board)
        {
            Piece piece = board[FromPos];
            bool capture = !board.IsEmpty(ToPos);
            board[ToPos] = piece;
            board[FromPos] = null; // Remove the piece from the original position
            piece.HasMoved = true; // Mark the piece as having moved

            return capture || piece.Type == PieceType.Pawn;
        }
    }
}
