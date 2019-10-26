using board;

namespace chess {
    class King : Piece {

        public King(Board b, Color c) : base(b, c) {

        }

        public override string ToString() {
            return "R";
        }
    }
}
