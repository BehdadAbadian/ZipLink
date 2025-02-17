using ZipLink.Application.Contracts.Interface;
using ZipLink.Domain.Link;

namespace ZipLink.Application.Services;
public class RediretService : IRedirectService
{
    private readonly ILinkRepository _repository;

    public RediretService(ILinkRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> GetLinkId(string path)
    {
        return await _repository.GetLinkIdWithPath(path);
    }

    public async Task<string> GetOrginalLinkAsync(string path)
    {
        return await _repository.GetOrginalLinkAsync(path);
    }
}
