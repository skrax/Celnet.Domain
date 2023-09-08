namespace Celnet.Domain.Interfaces
{
    public interface IApiMiddleware<TRequestBody, TResponseBody>
        where TRequestBody : class
        where TResponseBody : class
    {
        void Next();

        void Invoke(ReceiveContext<TRequestBody, TResponseBody> context);
    }
}