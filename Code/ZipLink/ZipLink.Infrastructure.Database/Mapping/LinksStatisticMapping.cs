using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZipLink.Domain.Statistic;

namespace ZipLink.Infrastructure.Database.Mapping;
public class LinksStatisticMapping : IEntityTypeConfiguration<LinksStatistic>
{
    public void Configure(EntityTypeBuilder<LinksStatistic> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LinkId).IsRequired();
        builder.Property(x => x.Ip).IsRequired();
        builder.Property(x => x.ReDirectDate).IsRequired();
    }
}
