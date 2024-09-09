using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackinListItemNameException : PackItException
    {
        public EmptyPackinListItemNameException() : base("Packing item name cannot be empty")
        {
        }
    }
}
