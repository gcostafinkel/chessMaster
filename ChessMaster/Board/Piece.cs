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



        public Piece (Board b, Color c) {
            this.position = null;
            this.board = b;
            this.color = c;
            this.movementQty = 0;
        }

        public void addMovementQty () {
            movementQty++;
        }
    }
}
