namespace Demonware.Request
{
    public class RequestParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public RequestParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
