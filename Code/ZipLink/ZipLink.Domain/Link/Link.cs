using ZipLink.Domain.Share;

namespace ZipLink.Domain.Link;
public class Link
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string OriginalLink { get; private set; }
    public string ShortLink { get; private set; }
    public DateTime CreationDate { get; private set; }
    public int ExpireTime { get; private set; }
    public Status LinkStatus { get; private set; }

    public static Link CreateNew(Guid userId, string title, string description, string originalLink, string shortLink, int expireTime, Status linkStatus = Status.Active)
    {
        var id = Guid.NewGuid();
        return new Link(id, userId, title, description, originalLink, shortLink, expireTime, linkStatus);
    }
    public void UpdateStatus(Status linkStatus)
    {
        LinkStatus = linkStatus;
    }
    public void Edit(string title, string description, string originalLink, string shortLink)
    {
        Title = title;
        Description = description;
        OriginalLink = originalLink;
        ShortLink = shortLink;
    }
    public void RenewExpireTime(int expireTime)
    {
        ExpireTime = expireTime;
    }
    private Link(Guid id, Guid userId, string title,string description ,string originalLink, string shortLink, int expireTime, Status linkStatus)
    {
        Id = id;
        UserId = userId;
        Title = title;
        Description = description;
        OriginalLink = originalLink;
        ShortLink = shortLink;
        CreationDate = DateTime.Now;
        ExpireTime = expireTime;
        LinkStatus = linkStatus;

    }
}
