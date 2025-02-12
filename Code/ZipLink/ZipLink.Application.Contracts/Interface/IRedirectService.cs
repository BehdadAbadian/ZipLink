namespace ZipLink.Application.Contracts.Interface;
public interface IRedirectService
{
    public Task<string> GetOrginalLinkAsync(string path);
}
