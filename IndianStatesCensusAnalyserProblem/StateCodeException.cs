using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class StateCodeException : Exception
    {
        public enum ExceptionType
        {
            FILE_INCORRECT,TYPE_INCORRECT,DELIMETER_INCORRECT,HEADER_INCORRECT
        }
        public ExceptionType type;
        public StateCodeException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
