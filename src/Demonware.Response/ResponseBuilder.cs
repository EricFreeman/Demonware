namespace Demonware.Response
{
    public static class ResponseBuilder
    {
        public static ResponseEnvelope<T> BuildForSuccess<T>(T result, string message)
        {
            return CreateResponseEnvelope(result, message, true);
        }

        public static ResponseEnvelope<T> BuildForFailure<T>(T result, string message)
        {
            return CreateResponseEnvelope(result, message, false);
        }

        private static ResponseEnvelope<T> CreateResponseEnvelope<T>(T result, string message, bool isSuccess)
        {
            return new ResponseEnvelope<T>
            {
                Completed = isSuccess,
                Message = message,
                Result = result
            };
        }
    }
}