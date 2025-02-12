
using ZipLink.Infrastructure.Database;

namespace ZipLink.Infrastructure.Pattern;
public class UnitOfwork : IUnitOfwork
{
    private readonly ZipLinkContext _context;

    public UnitOfwork(ZipLinkContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
