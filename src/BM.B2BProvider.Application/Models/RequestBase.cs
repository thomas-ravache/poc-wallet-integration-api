using BM.B2BProvider.Domain.Enums;

namespace BM.B2BProvider.Application;

public abstract class RequestBase
{
    public EB2BTypes B2BType { get; set; }
}