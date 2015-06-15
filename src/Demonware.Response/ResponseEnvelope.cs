namespace Demonware.Response
{
    public class ResponseEnvelope<T>
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public T Result { get; set; }
    }
}