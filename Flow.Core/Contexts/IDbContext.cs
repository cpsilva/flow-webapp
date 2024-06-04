using Microsoft.EntityFrameworkCore.Storage;

namespace Flow.Core.Contexts
{
    public interface IDbContext
    {
        public Task<bool> ExecuteInTrasactionAsync(Func<Task> action, int currentUserId);
        public IDbContextTransaction CurrentTransaction();
    }
}
