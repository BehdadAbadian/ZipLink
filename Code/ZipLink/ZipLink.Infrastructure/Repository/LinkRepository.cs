using ZipLink.Domain.Link;

namespace ZipLink.Infrastructure.Repository;

internal class LinkRepository : ILinkRepository
{
    public Task<bool> CheckGeneratedShortLink(string shortLink)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(Link link)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Link>> GetAllByUser(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Link>> GetAllLinks()
    {
        throw new NotImplementedException();
    }

    public Task<Link> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LinkExitsById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Link link)
    {
        throw new NotImplementedException();
    }
}
