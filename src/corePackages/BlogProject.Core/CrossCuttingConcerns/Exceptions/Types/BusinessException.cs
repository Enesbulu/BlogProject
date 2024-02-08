using System.Runtime.Serialization;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.Types
{
    public class BusinessException :Exception
    {
        public BusinessException(){}

        protected BusinessException(SerializationInfo info,StreamingContext context) : base(info: info, context: context) { }

        public BusinessException(string? message) : base(message) { }
        public BusinessException(string? message, Exception? innerException):base(message, innerException) { }
    }
}
