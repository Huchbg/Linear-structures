using System.Runtime.Serialization;

namespace Linear_structures
{
    [Serializable]
    internal class OutOfRangeException : Exception
    {
        public OutOfRangeException()
        {
        }

        public OutOfRangeException(string? message) : base(message)
        {
        }

        public OutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}