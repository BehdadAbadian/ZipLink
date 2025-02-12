namespace ZipLink.Infrastructure.Pattern;

public interface IUnitOfwork : IDisposable
{
    public Task SaveChangesAsync();
    public void Dispose();
}
