using board;
using System;
using System.Collections.Generic;
using System.Text;

namespace board {
    class Piece {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int movementQty { get; protected set; }

        public Board board { get; protected set; }

        public Piece (Position p, Board b, Color c) {
            this.position = p;
            this.board = b;
            this.color = c;
            this.movementQty = 0;
        }

    }
}
