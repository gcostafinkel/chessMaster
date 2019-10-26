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

        public Piece getPieces(int line, int row) {
            return pieces[line, row];
        }

        public void placePiece(Piece p, Position pos) {
            pieces[pos.line, pos.row] = p;
            p.position = pos;

        }
    }
}
