using System.Runtime.Serialization;

namespace Errors;

public class InvalidAgeException : Exception
{
    public InvalidAgeException() : base("\nGecersiz yas degeri girildi.\n") 
    {
    }

    public InvalidAgeException(string message) : base(message)
    {
    }

    public InvalidAgeException(string message, Exception inner) : base(message, inner)
    {
    }

    public InvalidAgeException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {
    }
}
