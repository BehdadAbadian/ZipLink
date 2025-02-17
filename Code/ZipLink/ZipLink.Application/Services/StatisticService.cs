using ZipLink.Application.Contracts.Interface;
using ZipLink.Domain.Statistic;
using ZipLink.Infrastructure.Pattern;

namespace ZipLink.Application.Services;

public class StatisticService : IStatisticService
{
    private readonly ILinkStatisticRepository _repository;
    private readonly IUnitOfwork _unitOfwork;

    public StatisticService(ILinkStatisticRepository repository, IUnitOfwork unitOfwork)
    {
        _repository = repository;
        _unitOfwork = unitOfwork;
    }
    public async Task AddRedirectRecord(Guid linkId, string ip)
    {
        var command = LinksStatistic.CreateNew(linkId, ip);
        await _repository.CreateAsync(command);
        await _unitOfwork.SaveChangesAsync();
    }
}
