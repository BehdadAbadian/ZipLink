using Microsoft.EntityFrameworkCore;
using ZipLink.Domain.Link;
using ZipLink.Infrastructure.Database;

namespace ZipLink.Infrastructure.Repository;

public class LinkRepository : ILinkRepository
{
    private readonly ZipLinkContext _context;

    public LinkRepository(ZipLinkContext context)
    {
        _context = context;
    }
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

    public async Task<string> GetOrginalLinkAsync(string shortLink)
    {
        //var c = await _context.Links.ToListAsync();
        if (await _context.Links.AnyAsync(x => "/" + x.ShortLink ==  shortLink))
        {
            return await _context.Links.Where(x => "/" + x.ShortLink == shortLink).Select(x => x.OriginalLink).FirstOrDefaultAsync();
        }
        else { return ""; }
         
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
