using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class Refactor
    {
        public string message;

        public Refactor(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            message = message.ToLower();
            if(message.Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
