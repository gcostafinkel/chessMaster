using board;
using System;
using System.Collections.Generic;
using System.Text;

namespace board {
    class Board {
        public int Lines {get; set;}
        public int Rows {get; set;}
        private Piece[,] pieces;

        public Board (int l, int r) {
            this.Lines = l;
            this.Rows = r;
            pieces = new Piece[Lines, Rows];

        }
    }
}
