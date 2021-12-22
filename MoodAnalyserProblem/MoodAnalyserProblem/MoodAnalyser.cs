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
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }

        public string AnalyseMood()
        {
            try
            {
                if (msg.ToLower().Contains(""))
                    return "HAPPY";

                else
                    return "SAD";
            }
            catch (NullReferenceException msg )
            {
                return "Happy";
            }
        }
    }
}