namespace ZipLink.Domain.Statistic;
public class LinksStatistic
{
    public Guid Id { get; private set; }
    public Guid LinkId { get; private set; }
    public string Ip { get; private set; }
    public DateTime ReDirectDate { get; private set; }

    public static LinksStatistic CreateNew(Guid linkId, string ip)
    {
        var id = Guid.NewGuid();
        return new LinksStatistic(id, linkId, ip);
    }


    private LinksStatistic(){}

    private LinksStatistic(Guid id, Guid linkId, string ip)
    {
        Id = id;
        LinkId = linkId;
        Ip = ip;
        ReDirectDate = DateTime.Now;
    }
}
