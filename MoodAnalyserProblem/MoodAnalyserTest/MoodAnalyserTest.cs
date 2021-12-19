using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void NullMood()
        {
            string message = "";
            string expected = "HAPPY";

            MoodAnalyser mood = new MoodAnalyser(message);
            
            string actual = mood.AnalyseMood();
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalyser moodAnalyser = new MoodAnalyser("");

            try
            {
                string actual = moodAnalyser.AnalyseMood();
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);

            try
            {
                string actual = moodAnalyser.AnalyseMood1();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
       