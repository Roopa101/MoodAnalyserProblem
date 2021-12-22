using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyser mood = new MoodAnalyser(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalyser modeAnalyzer = new MoodAnalyser(" ");

            try
            {
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalyser modeAnalyzer = new MoodAnalyser(string.Empty);

            try
            {
                string actual = modeAnalyzer.AnalyseMood1();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}