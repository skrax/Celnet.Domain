using System;

namespace Celnet.Domain
{
    public interface IApiBuilder<out TBody, in TResponse> 
        where TBody : class where TResponse : class 
    {
        IApiBuilder<TBody, TResponse> MapGet(string route, Func<TBody?, TResponse> functor);

        IApiBuilder<TBody, TResponse> MapPost(string route, Func<TBody, TResponse> functor);

        IApiBuilder<TBody, TResponse> MapPut(string route, Func<TBody, TResponse> functor);

        IApiBuilder<TBody, TResponse> MapDelete(string route, Func<TBody, TResponse> functor);

        IApiBuilder<TBody, TResponse> MapEvent(string route, Action<TBody> act);
    }
}