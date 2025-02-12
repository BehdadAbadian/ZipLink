using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZipLink.Domain.Link;

namespace ZipLink.Infrastructure.Database.Mapping;

public class LinkMapping : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.OriginalLink).IsRequired();
        builder.Property(x => x.ShortLink).IsRequired();
        builder.Property(x => x.CreationDate).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Title).IsRequired();
        builder.Property(x => x.ExpireTime).IsRequired();
        builder.Property(x => x.LinkStatus).IsRequired();
    }
}
