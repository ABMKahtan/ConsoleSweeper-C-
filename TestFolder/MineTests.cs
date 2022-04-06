using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MineSweeper
{
    [TestClass]
    
    // _____Tests For the name of the file
    public class MineTests
    {    
        [TestMethod]
        public void TestMethod1()
        {
            //Assert.AreEqual("Expected outcome", "Actual Outcome", "Error message if test fails");

            Mine mineTest = new Mine();
            Assert.AreEqual(false,mineTest.getIsMine(),"Initialised incorrectly");
            mineTest.setMine();
            Assert.AreEqual(true, mineTest.getIsMine(), "Boolian did not change");
        }

    }

}