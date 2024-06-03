namespace Minimal.API.Requests
{
    public class UpdateProductRequest
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Currency { get; set; }
        public string Amount { get; set; }
    }
}
