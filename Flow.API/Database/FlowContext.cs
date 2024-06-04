using Flow.API.Database.Configuration;
using Flow.API.Entidades;
using Flow.Core.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Flow.API.Database
{
    public class FlowContext : DbContext, IDbContext
    {
        public FlowContext(DbContextOptions options) : base(options)
        { }

        public virtual DbSet<Processo> ProcessoTb { get; set; }
        public virtual DbSet<MapeamentoProcesso> MapeamentoProcessoTb { get; set; }

        public IDbContextTransaction CurrentTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExecuteInTrasactionAsync(Func<Task> action, int currentUserId)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProcessoEntityConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
