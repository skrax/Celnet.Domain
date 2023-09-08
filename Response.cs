using System;

namespace Celnet.Domain
{
    public class Response<T> where T : class
    {
        public Guid Id { get; set; }
        
        public Guid RequestId { get; set; }
        
        public string RequestRoute { get; set; }
        
        public int Code { get; set; }
        
        public T? Body { get; set; }
    }
}