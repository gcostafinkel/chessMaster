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

        public Piece piece(int line, int row) {
            return pieces[line, row];
        }

        public Boolean placeAlreadyOccupied (Position pos) {
            validatePosition(pos);
            return piece(pos) != null;
        }
        public Piece piece (Position pos) {
            if (validPosition(pos))
                return pieces[pos.line, pos.row];
            else {
                validatePosition(pos);
                return null;
            }
        }

        public bool validPosition (Position pos) {
            if (pos.line >= 0 && pos.line <= 7 && pos.row >= 0 && pos.row <= 7)
                return true;
            else
                return false;
        }

        public void validatePosition(Position pos) {
            if (!validPosition(pos)) {
                throw new BoardException("This position is not valid!");
            }

        }

        public void placePiece(Piece p, Position pos) {
            if (placeAlreadyOccupied(pos)) {
                throw new BoardException("Place already occupied!");
            }
            pieces[pos.line, pos.row] = p;
            p.position = pos;

        }
    }
}
