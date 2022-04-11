using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Settings
    {
        //Attributes
        int totalNoofMines;
        int boardSize;
        
        //Constructor
        public Settings(){

            bool goodInput = false;
            string difficulty = "";

            Console.WriteLine("Hello Please Choose Your Settings:");
            Console.WriteLine("What difficulty would you like to play?");
            Console.WriteLine("Easy / Medium / Hard");
            while(goodInput == false){
                goodInput = false;
                difficulty = Console.ReadLine().ToLower();

                if (difficulty.Equals("easy") || difficulty.Equals("medium") || difficulty.Equals("hard")){
                    goodInput = true;
                }
                else{
                    Console.WriteLine("Sorry you did not select a valid difficulty.");
                    Console.WriteLine("Please Try Again");
                }
            }
            

            
        }


        //Methods
        public int getTotalNumberOfMines(){
            return this.totalNoofMines;
        }
        public int getBoardSize(){
            return this.boardSize;
        }
    }
}