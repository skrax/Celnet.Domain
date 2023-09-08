using System.Diagnostics.CodeAnalysis;

namespace Celnet.Domain
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Method
    {
        GET,
        POST,
        PUT,
        DELETE,
        EVENT
    }
}