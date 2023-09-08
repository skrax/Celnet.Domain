namespace Celnet.Domain
{
    public interface IApi<in TBody, out TResponse> where TBody : class where TResponse : class
    {
        TResponse Get(string route, TBody? body);

        TResponse Post(string route, TBody body);

        TResponse Put(string route, TBody body);

        TResponse Delete(string route, TBody body);

        void Event(string route, TBody body);
    }
}