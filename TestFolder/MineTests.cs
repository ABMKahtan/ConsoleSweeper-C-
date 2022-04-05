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
            Mine mineTest = new Mine();

            Assert.AreEqual(false,mineTest.getIsMine(),"Initialised incorrectly");
        }

    }

}