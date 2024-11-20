namespace BusController.Domain
{
    public class ApiLogItem
    {
        public ApiRequest Request { get; set; }
        public ApiResponse Response { get; set; }
        public ErrorLog Error { get; set; }

    }

    public class ErrorLog
    {
        public ErrorLogTypes ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetail { get; set; }
        public string ErrorMethodName { get; set; }
        public DateTime? Logdt { get; set; }
    }
    public class ApiRequest
    {

        public ApiRequestTypes RequestType { get; set; }
        public string RequestStr { get; set; }
        public DateTime? Logdt { get; set; }

    }
    public class ApiResponse
    {
        public ApiResponseTypes ResponseType { get; set; }
        public string ResponseStr { get; set; }
        public DateTime? Logdt { get; set; }
    }

    public enum ErrorLogTypes
    {
        Exception,
        ApiError
    }

    public enum ApiRequestTypes
    {
        ApiRequest
    }

    public enum ApiResponseTypes
    {
        ApiResponse
    }
}
