using System.Runtime.Serialization;

namespace Diablo.Helpers
{
    [Serializable]
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException()
        {
        }

        public InvalidArmourException(string? message) : base(message)
        {
        }

        public InvalidArmourException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidArmourException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}