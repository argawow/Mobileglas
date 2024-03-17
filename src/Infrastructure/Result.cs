namespace Infrastructure
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public ErrorResponse Error { get; set; }
        public static Result<T> Success(T value) => new Result<T> { IsSuccess = true, Value = value };
    }
}