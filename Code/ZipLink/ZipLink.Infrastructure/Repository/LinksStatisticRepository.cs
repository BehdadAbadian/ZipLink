using ZipLink.Domain.Statistic;
using ZipLink.Infrastructure.Database;

namespace ZipLink.Infrastructure.Repository;

public class LinksStatisticRepository : ILinkStatisticRepository
{
    private readonly ZipLinkContext _context;

    public LinksStatisticRepository(ZipLinkContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(LinksStatistic link)
    {
        await _context.LinksStatistics.AddAsync(link);
    }

    public Task<List<LinksStatistic>> GetAllByIp(string ip)
    {
        throw new NotImplementedException();
    }

    public Task<List<LinksStatistic>> GetAllByLinkId(string ip)
    {
        throw new NotImplementedException();
    }

    public Task<List<LinksStatistic>> GetAllLinkStatistic()
    {
        throw new NotImplementedException();
    }

    public Task<LinksStatistic> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LinkStatisticExitsById(Guid id)
    {
        throw new NotImplementedException();
    }
}
