using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Enums;

namespace BM.B2BProvider.Application.Interfaces.Factories;

public interface IB2BProviderFactory
{
    IB2BProvider GetProvider(EB2BTypes b2bType);
}