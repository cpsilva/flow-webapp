using Flow.API.Entidades;
using Flow.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flow.API.Database.Configuration
{
    public class ProcessoEntityConfiguration : IEntityTypeConfiguration<Processo>
    {
        private readonly string _tableName = $"{nameof(Processo)}Tb".ToSnakeCase();

        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.ToTable(_tableName);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.HasKey(t => t.Id).HasName($"Pk_{_tableName}");

            builder.Property(t => t.ProcessoId).IsRequired();

            builder.Property(t => t.ProcessoPaiId);

            builder.Property(t => t.Ativo)
                .HasDefaultValue(true);

            builder.Property(t => t.DataInclusao)
                   .HasDefaultValueSql("now()");

            builder.Property(t => t.DataAlteracao);
        }
    }
}
