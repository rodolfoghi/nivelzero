namespace NivelZero.Application.Common;

public interface IAppService
{
    ValueTask<bool> CommitAsync();
}