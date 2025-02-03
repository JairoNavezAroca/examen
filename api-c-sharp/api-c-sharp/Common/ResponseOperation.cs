namespace api_c_sharp.Common
{
    public class ResponseOperation<T>
    {
        public bool Success { set; get; }
        public T Data { set; get; }
        public string Message { set; get; }
    }
}
