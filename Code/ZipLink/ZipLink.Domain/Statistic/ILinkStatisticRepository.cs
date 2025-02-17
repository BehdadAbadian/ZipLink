namespace ZipLink.Domain.Statistic;
public interface ILinkStatisticRepository
{
    public Task CreateAsync(LinksStatistic link);
    public Task<LinksStatistic> GetAsync(Guid id);
    public Task<List<LinksStatistic>> GetAllByIp(string ip);
    public Task<List<LinksStatistic>> GetAllByLinkId(string ip);
    public Task<List<LinksStatistic>> GetAllLinkStatistic();
    public Task<bool> LinkStatisticExitsById(Guid id);
}
