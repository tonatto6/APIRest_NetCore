namespace API_NET.Models
{
    public class ResponseError
    {
        public int StatusCode { get; set; } = 500;

        public bool Error { get; set; } = true;

        public string Body { get; set; }
    }
}
