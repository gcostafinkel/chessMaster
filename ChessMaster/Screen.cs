using board;
using chess;
using System;

namespace ChessMaster {
    class Screen {
        public static void printBoard(Board board) {
            for (int i = 0; i < board.Lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Lines; j++) {
                    if (board.piece(i, j) != null)
                        Screen.printPiece(board.piece(i,j));
                    else
                        Console.Write("- ");
                }
                System.Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void printPiece (Piece piece) {
            if (piece.color == Color.White) {
                Console.Write(piece + " ");
            }
            if (piece.color == Color.Black) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static PositionChess readPositionChess() {
            string s = Console.ReadLine();
            char row = s[0];
            int line = int.Parse(s[1] + " ");
            return new PositionChess(row, line);
        }
    }
}
