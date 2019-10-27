using board;

namespace chess {
    class ChessMatch {
        public Board board { get; private set;  }
        private int turn;
        private Color actualTurn;
        public bool finished { get; private set; }

        public ChessMatch () {
            board = new Board(8, 8);
            turn = 1;
            actualTurn = Color.White;
            finished = false;
            placePieces();
        }

        public void movement (Position origin, Position destiny) {
            Piece p = board.removePiece(origin);
            p.addMovementQty();
            Piece lostPiece = board.removePiece(destiny);
            board.placePiece(p, destiny);
        }

        private void placePieces() {
            board.placePiece(new Tower(board, Color.White), new PositionChess('c', 1).toPosition());
            board.placePiece(new Tower(board, Color.White), new PositionChess('c', 2).toPosition());
            board.placePiece(new Tower(board, Color.White), new PositionChess('d', 2).toPosition());
            board.placePiece(new Tower(board, Color.White), new PositionChess('e', 2).toPosition());
            board.placePiece(new Tower(board, Color.White), new PositionChess('e', 1).toPosition());
            board.placePiece(new King(board, Color.White), new PositionChess('d', 1).toPosition());

            board.placePiece(new Tower(board, Color.Black), new PositionChess('c', 7).toPosition());
            board.placePiece(new Tower(board, Color.Black), new PositionChess('c', 8).toPosition());
            board.placePiece(new Tower(board, Color.Black), new PositionChess('d', 7).toPosition());
            board.placePiece(new Tower(board, Color.Black), new PositionChess('e', 7).toPosition());
            board.placePiece(new Tower(board, Color.Black), new PositionChess('e', 8).toPosition());
            board.placePiece(new King(board, Color.Black), new PositionChess('d', 8).toPosition());
        }
    }
}
