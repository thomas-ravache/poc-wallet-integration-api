using System.Text.Json.Serialization;
using BM.B2BProvider.Domain.Enums;

namespace BM.B2BProvider.Application;

public abstract class RequestBase
{
    [JsonPropertyName("b2bType")]
    public EB2BTypes B2BType { get; set; }
}