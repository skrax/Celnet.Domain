using System;

namespace Celnet.Domain
{
    public class Request<T> where T : class
    {
        public Guid Id { get; set; }
        
        public string? Route { get; set; }
        
        public Method Method { get; set; }
        
        public T? Body { get; set; }
    }
}