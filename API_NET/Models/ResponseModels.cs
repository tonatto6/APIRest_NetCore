namespace API_NET.Models
{
    public class ResponseModels<T>
    {
        public int StatusCode { get; set; } = 200;

        public bool Error { get; set; } = false;

        public T Body { get; set; }
    }
}
