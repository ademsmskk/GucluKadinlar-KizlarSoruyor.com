public class ServiceResponse<T>
{
    private ResponseCodeEnum _responseCode;
    public ResponseCodeEnum ResponseCode
    {
        get { return _responseCode; }
        set
        {
            _responseCode = value;
            this.ResponseMessage = MessageGenarator.ResponseMessageGenarator(value);
        }
    }

    public string ResponseMessage { get; set; }
    public T? Data { get; set; }
}