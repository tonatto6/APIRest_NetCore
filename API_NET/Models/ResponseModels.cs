namespace API_NET.Models
{
    public class ResponseModels<T>
    {
        public int StatusCode { get; set; }

        public T Body { get; set; }
    }
}
