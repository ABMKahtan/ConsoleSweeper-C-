using System;

namespace MineSweeper{
    internal class Mine{
        //attributes
        bool isMine;
        bool isFlag;
        bool isRevealed;
        int mineCounter;
        int[] coordinates = new int[2];
        

        //constructor
        public Mine(){
            this.isFlag = false;
            this.isMine = false;
            this.isRevealed = false;
        }

        //methods
        public bool getIsMine(){
            return this.isMine;
        }
        public void setMine(){
            this.isMine = true;
        }
        public void setCoordinates(int x,int y){
            this.coordinates[0] = x;
            this.coordinates[1] = y;
        }
        public int getXCoordinate(){
            return this.coordinates[0];
        }
        public int getYCoordinate(){
            return this.coordinates[1];
        }
        public void setMineCounter(int touchingMines){
            this.mineCounter = touchingMines;
        }
        public int getMineCounter(){
            return this.mineCounter;
        }
        public bool getIsRevealed(){
            return this.isRevealed;
        }
        public void setRevealed(){
            this.isRevealed = true;
        }
        public void swapFlagStatus(){
            this.isFlag = !this.isFlag;
        }
        public bool getIsFlag(){
            return this.isFlag;
        }

    }
}