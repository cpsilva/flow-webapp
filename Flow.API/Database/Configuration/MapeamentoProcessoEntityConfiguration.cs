using Flow.API.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flow.API.Database.Configuration
{
    public class MapeamentoProcessoEntityConfiguration : IEntityTypeConfiguration<MapeamentoProcesso>
    {
        public void Configure(EntityTypeBuilder<MapeamentoProcesso> builder)
        {
            throw new NotImplementedException();
        }
    }
}
