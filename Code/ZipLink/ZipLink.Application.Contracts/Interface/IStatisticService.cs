namespace ZipLink.Application.Contracts.Interface;
public interface IStatisticService
{
    public Task AddRedirectRecord(Guid linkId, string ip);
}
