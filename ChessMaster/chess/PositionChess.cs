using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess {
    class PositionChess {
        public int line { get; set; }
        public char row { get; set; }
        
        public PositionChess (char r, int l) {
            this.line = l;
            this.row = r;
        }

        public Position toPosition () {
            return new Position(8 - line, row - 'a');
        } 
        public override string ToString() {
            return "" + row + line;
        }
    }

}
