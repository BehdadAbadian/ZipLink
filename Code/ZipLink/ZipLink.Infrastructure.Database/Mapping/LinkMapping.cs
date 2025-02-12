using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZipLink.Domain.Link;

namespace ZipLink.Infrastructure.Database.Mapping;

public class LinkMapping : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        throw new NotImplementedException();
    }
}
