using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRouletteAssessment2020;

namespace RussianRouletteUnitTest2020
{
    [TestClass]
    public class UnitTest1
    {
        private Battle myClass = new Battle();
        [TestMethod]
        public void AttackMethodTesting()
        {
            //Random number generator was changed to a hardcoded number for testing purposes
            myClass.Prepare();

            var Answer = myClass.Attack("4");

            Assert.AreEqual("Your attack failed", Answer);
        }

        [TestMethod]
        public void AttackMethodTesting1()
        {
            //Random number generator was changed to a hardcoded number for testing purposes
            myClass.Prepare();

            var Answer = myClass.Attack("3");

            Assert.AreEqual("You have enliminated your enemy", Answer);
        }

        [TestMethod]
        public void ScoreMethodTesting()
        {
            var Answer = myClass.Score("You have enliminated your enemy", "3");

            Assert.AreEqual("4", Answer);
        }

        [TestMethod]
        public void ScoreMethodTesting1()
        {
            var Answer = myClass.Score("Your attack failed", "3");

            Assert.AreEqual("2", Answer);
        }

        [TestMethod]
        public void HighScoreMethodTesting()
        {
            var Answer = myClass.HighScore("5", "3");

            Assert.AreEqual("5", Answer);
        }

        [TestMethod]
        public void HighScoreMethodTesting1()
        {
            var Answer = myClass.HighScore("2", "3");

            Assert.AreEqual("3", Answer);
        }

    }
}
