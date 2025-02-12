using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using ZipLink.Domain.Link;
using ZipLink.Domain.Statistic;
using ZipLink.Infrastructure.Database.Mapping;

namespace ZipLink.Infrastructure.Database;

public class ZipLinkContext : DbContext
{
    public DbSet<Link> Links { get; set; }
    public DbSet<LinksStatistic> LinksStatistics { get; set; }
    public ZipLinkContext(DbContextOptions<ZipLinkContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(LinkMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}
