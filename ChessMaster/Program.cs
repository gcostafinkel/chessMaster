using System;
using board;
using chess;

namespace ChessMaster {
    class Program {
        static void Main(string[] args) {
            try {

                ChessMatch cm = new ChessMatch();
                while (!cm.finished) {
                    Console.Clear();
                    Screen.printBoard(cm.board);

                    Console.WriteLine();
                    Console.Write("Digite a posicao de origem: ");
                    Position origin = Screen.readPositionChess().toPosition();
                    Console.Write("Digite a posicao de destino: ");
                    Position destiny = Screen.readPositionChess().toPosition();

                    cm.movement(origin, destiny);
                }

            }
            catch (BoardException e) {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
