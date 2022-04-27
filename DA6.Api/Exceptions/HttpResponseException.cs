namespace DA6.Api.Exceptions
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException(object? value = null) =>
          (Value) = (value);
        public object? Value { get; }
    }
}
