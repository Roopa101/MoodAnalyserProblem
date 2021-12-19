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
            catch (NullReferenceException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Null_Type_Exception, "Message should not be null");
            }
        }

        public string AnalyseMood1()
        {
            try
            {
                if (message.ToLower().Contains(string.Empty))
                {
                    return "happy";
                }
                else
                    return "sad";
            }
            catch (NullReferenceException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Empty_Type_Exception, "Message should not be empty");
            }
        }
    }
}
   