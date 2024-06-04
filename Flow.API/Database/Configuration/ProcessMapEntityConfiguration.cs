using Flow.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flow.API.Database.Configuration
{
    public class ProcessMapEntityConfiguration : IEntityTypeConfiguration<ProcessMap>
    {
        public void Configure(EntityTypeBuilder<ProcessMap> builder)
        {
            throw new NotImplementedException();
        }
    }
}
