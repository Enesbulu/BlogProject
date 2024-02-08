using BlogProject.Core.Business.Abstract;

namespace BlogProject.Core.Business.Concrete
{
    public class CustomResponseDto<T> : ICustomResponseDto<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public static CustomResponseDto<T> Success(int statusCode, T data, bool isSuccess)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data, IsSuccess = isSuccess };
        }
        public static CustomResponseDto<T> Success(int statusCode, bool isSuccess)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, IsSuccess = isSuccess };
        }
    }
}
