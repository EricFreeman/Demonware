namespace Demonware.Response
{
    public class ResponseEnvelope<T>
    {
        public string Message { get; set; }
        public bool Completed{ get; set; }
        public T Result { get; set; }
    }
}