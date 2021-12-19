using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {

        private string message;
        public string AnalyzeMood(String message)
        {
            if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            
        }
    }
}
