using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    [Serializable]
    public class NameTooShortException : ApplicationException
    {
        public NameTooShortException() { }
        public NameTooShortException(string message) : base(message) { }
        public NameTooShortException(string message, System.Exception inner) : base(message, inner) { }
        protected NameTooShortException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class SpeedToHighException : ApplicationException
    {
        public SpeedToHighException() { }
        public SpeedToHighException(string message) : base(message) { }
        public SpeedToHighException(string message, System.Exception inner) : base(message, inner) { }
        protected SpeedToHighException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
