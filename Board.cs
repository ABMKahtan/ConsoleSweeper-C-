using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Board
    {
        //attributes
        Mine[,] board;
        int noOfMines;
        int boardSize;

        //constructor
        public Board(int boardSize){
            this.board = new Mine[boardSize,boardSize];
        }
        //methods
    }
}