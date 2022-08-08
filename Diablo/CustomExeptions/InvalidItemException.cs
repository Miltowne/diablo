using System.Runtime.Serialization;

namespace Diablo.Helpers
{
    [Serializable]
    internal class InvalidItemException : Exception
    {
        public InvalidItemException()
        {
        }

        public InvalidItemException(string? message) : base(message)
        {
        }

        public InvalidItemException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}