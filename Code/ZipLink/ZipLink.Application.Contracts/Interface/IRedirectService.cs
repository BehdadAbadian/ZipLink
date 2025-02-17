namespace ZipLink.Application.Contracts.Interface;
public interface IRedirectService
{
    public Task<string> GetOrginalLinkAsync(string path);
    public Task<Guid> GetLinkId(string path);
}
