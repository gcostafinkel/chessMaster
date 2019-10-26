using System;
using board;
using chess;

namespace ChessMaster {
    class Program {
        static void Main(string[] args) {
            try {

                PositionChess pos = new PositionChess('a', 1);
                Console.WriteLine(pos); 
                Console.WriteLine(pos.toPosition());

                PositionChess pos2 = new PositionChess('c', 7);
                Console.WriteLine(pos2);
                Console.WriteLine(pos2.toPosition());

            }
            catch (BoardException e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
