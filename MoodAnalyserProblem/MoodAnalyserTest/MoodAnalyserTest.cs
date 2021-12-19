using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void messageSadMood()
        {
            string message = "";
            string expected = "HAPPY";

            MoodAnalyser obj = new MoodAnalyser(message);
            
            string actual = obj.AnalyseMood();
            
            Assert.AreEqual(expected, actual);
        }
    }
}
       