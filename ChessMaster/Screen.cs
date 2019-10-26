﻿using board;
using System;

namespace ChessMaster {
    class Screen {
        public static void printBoard(Board board) {
            for (int i = 0; i < board.Lines; i++) {
                for (int j = 0; j < board.Lines; j++) {
                    if (board.getPieces(i, j) != null)
                        Console.Write(board.getPieces(i, j) + " ");
                    else
                        Console.Write("- ");
                }
                System.Console.WriteLine();
            }
        }
    }
}