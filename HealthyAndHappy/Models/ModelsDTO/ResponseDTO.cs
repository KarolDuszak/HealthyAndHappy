namespace HealthyAndHappy.Models.ModelsDTO
{
    public enum ResponseStatus
    {
        Successful,
        Unsuccessful
    }
    public class ResponseDTO
    {
        public string Message { get; set; }
        public ResponseStatus Status { get; set; }
        public int Code { get; set; }

        public ResponseDTO() { }
        private ResponseDTO(string message, ResponseStatus status, int code)
        {
            Message = message;
            Status = status;
            Code = code;
        }

        public static ResponseDTO Successful() => new ResponseDTO("OK", ResponseStatus.Successful, 0);
        public static ResponseDTO Unsuccessful() => new ResponseDTO("NotOK", ResponseStatus.Unsuccessful, 1);

    }
}
