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
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyser obj = new MoodAnalyser(msg);

            string actual = obj.AnalyseMood();

            Assert.AreEqual(expected, actual);

        }
    }
}