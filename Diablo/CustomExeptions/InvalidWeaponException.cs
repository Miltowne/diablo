using System.Runtime.Serialization;

namespace Diablo.Helpers
{
    [Serializable]
    public class InvalidWeaponException : Exception
    {
        /// <summary>
        /// Exceptions specific for Weapon class items
        /// </summary>
        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string? message) : base(message)
        {
        }

        public InvalidWeaponException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidWeaponException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}