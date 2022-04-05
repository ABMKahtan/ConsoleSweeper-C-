using System;

namespace MineSweeper{
    internal class Mine{
        //attributes
        bool isMine;
        bool isFlag;
        int mineCounter;
        //constructor

        //methods
        public bool getIsMine(){
            return this.isMine;
        }
        public void setMine(){
            this.isMine = !this.isMine;
        }
    }
}