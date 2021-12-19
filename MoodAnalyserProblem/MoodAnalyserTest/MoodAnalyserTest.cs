using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser Analyze = new MoodAnalyser();
            string expected = "Sad";
            string actual = Analyze.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            MoodAnalyser analyzer = new MoodAnalyser();
            string expected = "Happy";
            string actual = analyzer.AnalyzeMood(" I am in any mood");
            Assert.AreEqual(expected, actual);
        }
    }
}
