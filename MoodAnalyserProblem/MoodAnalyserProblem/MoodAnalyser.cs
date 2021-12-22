using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string msg;
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";

            else
                return "HAPPY";
        }

    }
}
