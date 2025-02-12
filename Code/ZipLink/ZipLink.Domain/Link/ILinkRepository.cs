namespace ZipLink.Domain.Link;
public interface ILinkRepository
{
    public Task CreateAsync(Link link);
    public Task UpdateAsync(Link link);
    public Task DeleteAsync(Guid id);
    public Task<Link> GetAsync(Guid id);
    public Task<List<Link>> GetAllByUser(Guid userId);
    public Task<List<Link>> GetAllLinks();
    public Task<bool> LinkExitsById(Guid id);
    public Task<bool> CheckGeneratedShortLink(string shortLink);



}
