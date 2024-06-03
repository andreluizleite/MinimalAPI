namespace Minimal.API.Exceptions
{
    public class ProductNotFoundException: Exception
    {
        public ProductNotFoundException() { }
        public ProductNotFoundException(string message) : base(message) { }
        public ProductNotFoundException(string message, ProductNotFoundException innerException) : base(message, innerException) { }
    }
}
