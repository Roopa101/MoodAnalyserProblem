using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void msgSadMood()
        {
            string message = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyser mood = new MoodAnalyser();

            string actual = mood.AnalyseMood(message);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void msgHaapyMood()
        {
            string message = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyser mood = new MoodAnalyser();

            string actual = mood.AnalyseMood(message);

            Assert.AreEqual(expected, actual);
        }

    }
}