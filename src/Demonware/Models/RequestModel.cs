using Demonware.Request;

namespace Demonware.Models
{
    public class RequestModel
    {
        public string Url { get; set; }
        public RequestParameter[] Parameters { get; set; }
    }
}