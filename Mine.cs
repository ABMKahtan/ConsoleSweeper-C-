using System;

namespace MineSweeper{
    internal class Mine{
        //attributes
        bool isMine;
        bool isFlag;
        int mineCounter;
        int[] coordinates = new int[2];

        //constructor
        public Mine(){
            this.isFlag = false;
            this.isMine = false;
        }

        //methods
        public bool getIsMine(){
            return this.isMine;
        }
        public void setMine(){
            this.isMine = !this.isMine;
        }
        public void setCoordinates(int x,int y){
            this.coordinates[0] = x;
            this.coordinates[1] = y;
        }
        public void countMines(){

        }

    }
}