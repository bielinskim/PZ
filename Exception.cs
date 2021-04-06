using System;

namespace Lab03Library
{
    class Exception
    {

        [Serializable]
        public class AddDocumentException : ApplicationException
        {
            public AddDocumentException() { }
            public AddDocumentException(string message) : base(message) { }
            public AddDocumentException(string message, System.Exception inner) : base(message, inner) { }
            protected AddDocumentException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class AddVolumeException : ApplicationException
        {
            public AddVolumeException() { }
            public AddVolumeException(string message) : base(message) { }
            public AddVolumeException(string message, System.Exception inner) : base(message, inner) { }
            protected AddVolumeException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class AddBookException : ApplicationException
        {
            public AddBookException() { }
            public AddBookException(string message) : base(message) { }
            public AddBookException(string message, System.Exception inner) : base(message, inner) { }
            protected AddBookException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
