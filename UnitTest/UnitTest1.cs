using NimGame;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_SwitchPlayerTurn()
        {
            var game = new NimGames();
            game.isPlayerOneTurn = true;

            game.switchPlayerTurn();

            Assert.IsFalse(game.isPlayerOneTurn);
        }

        [TestMethod]
        public void TestMethod_RemovePegs() 
        {
            var game = new NimGames();
            int value = 3;

            game.removePegs(value);

            Assert.AreEqual(15, game.pegsRemaining());
        }
    }
}