using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MineSweeper
{
    [TestClass]
    
    // _____Tests For the name of the file
    public class MineTests
    {    
        Mine mineTest = new Mine();

        [TestMethod]
        public void TestMineSet()
        {
            //Assert.AreEqual("Expected outcome", "Actual Outcome", "Error message if test fails");
            Assert.AreEqual(false,mineTest.getIsMine(),"Initialised incorrectly");
            mineTest.setMine();
            Assert.AreEqual(true, mineTest.getIsMine(), "Boolian did not change");
            mineTest.setCoordinates(0,0);
            Assert.AreEqual(0,mineTest.getXCoordinate(), "X Coordinate did not set Correctly");
            Assert.AreEqual(0,mineTest.getYCoordinate(), "Y Coordinate did not set Correctly");
        }
    }
}