using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Celnet.Domain
{
    public class Backend<TBody, TResponse> : IApiBuilder<TBody, TResponse>, IApi<TBody, TResponse>
        where TBody : class where TResponse : class
    {
        private readonly IDictionary<string, Func<TBody?, TResponse>> _get;

        private readonly IDictionary<string, Func<TBody, TResponse>> _post;

        private readonly IDictionary<string, Func<TBody, TResponse>> _put;

        private readonly IDictionary<string, Func<TBody, TResponse>> _delete;

        private readonly IDictionary<string, Action<TBody>> _event;

        public Backend(
            IDictionary<string, Func<TBody?, TResponse>> get,
            IDictionary<string, Func<TBody, TResponse>> post,
            IDictionary<string, Func<TBody, TResponse>> put,
            IDictionary<string, Func<TBody, TResponse>> delete,
            IDictionary<string, Action<TBody>> @event
        )
        {
            _get = get;
            _post = post;
            _put = put;
            _delete = delete;
            _event = @event;
        }

        public static Backend<TBody, TResponse> Make() => new Backend<TBody, TResponse>(
            new Dictionary<string, Func<TBody?, TResponse>>(),
            new Dictionary<string, Func<TBody, TResponse>>(),
            new Dictionary<string, Func<TBody, TResponse>>(),
            new Dictionary<string, Func<TBody, TResponse>>(),
            new Dictionary<string, Action<TBody>>()
        );

        public static Backend<TBody, TResponse> MakeConcurrent() => new Backend<TBody, TResponse>(
            new ConcurrentDictionary<string, Func<TBody?, TResponse>>(),
            new ConcurrentDictionary<string, Func<TBody, TResponse>>(),
            new ConcurrentDictionary<string, Func<TBody, TResponse>>(),
            new ConcurrentDictionary<string, Func<TBody, TResponse>>(),
            new ConcurrentDictionary<string, Action<TBody>>()
        );

        public IApiBuilder<TBody, TResponse> MapGet(string route, Func<TBody?, TResponse> functor)
        {
            _get.Add(route, functor);
            return this;
        }

        public IApiBuilder<TBody, TResponse> MapPost(string route, Func<TBody, TResponse> functor)
        {
            _post.Add(route, functor);
            return this;
        }

        public IApiBuilder<TBody, TResponse> MapPut(string route, Func<TBody, TResponse> functor)
        {
            _put.Add(route, functor);
            return this;
        }

        public IApiBuilder<TBody, TResponse> MapDelete(string route, Func<TBody, TResponse> functor)
        {
            _delete.Add(route, functor);
            return this;
        }

        public IApiBuilder<TBody, TResponse> MapEvent(string route, Action<TBody> act)
        {
            _event.Add(route, act);
            return this;
        }

        public TResponse Get(string route, TBody? body) => _get[route](body);

        public TResponse Post(string route, TBody body) => _post[route](body);

        public TResponse Put(string route, TBody body) => _put[route](body);

        public TResponse Delete(string route, TBody body) => _delete[route](body);
        public void Event(string route, TBody body) => _event[route](body);
    }
}