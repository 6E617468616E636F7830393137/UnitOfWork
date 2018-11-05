namespace UnitOfWork.Entities.Models.Response
{
    public class Response
    {
        public object Result { get; set; }
        public bool Success { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
