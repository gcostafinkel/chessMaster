using System;
using board;
using chess;

namespace ChessMaster {
    class Program {
        static void Main(string[] args) {
            try {

                Board board = new Board(8, 8);
                board.placePiece(new King(board, Color.Black), new Position(0, 1));
                board.placePiece(new Tower(board, Color.Black), new Position(2, 6));
                board.placePiece(new King(board, Color.White), new Position(3, 3));
                board.placePiece(new Tower(board, Color.White), new Position(5, 5));
                board.placePiece(new King(board, Color.Black), new Position(6, 0));
                Screen.printBoard(board);

            }
            catch (BoardException e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
