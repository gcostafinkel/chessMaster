using System;
using board;
using chess;

namespace ChessMaster {
    class Program {
        static void Main(string[] args) {
            try {
                Board board = new Board(8, 8);

                board.placePiece(new Tower(board, Color.Black), new Position(0, 0));
                Screen.printBoard(board);
                Console.WriteLine();
                board.placePiece(new Tower(board, Color.Black), new Position(1, 3));
                Screen.printBoard(board);
                Console.WriteLine();
                board.placePiece(new King(board, Color.Black), new Position(0, 9));

                Screen.printBoard(board);
            }
            catch (BoardException e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
