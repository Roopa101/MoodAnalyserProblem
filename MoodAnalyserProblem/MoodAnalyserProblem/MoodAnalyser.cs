using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {

        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains(""))
                    return "HAPPY";
                else
                    return "SAD";
            }
            catch (NullReferenceException message)
            {
                return "Happy";
            }
        }
    }
}
