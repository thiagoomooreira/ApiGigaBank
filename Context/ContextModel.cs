using GigaBank.Models;
using Microsoft.EntityFrameworkCore;

namespace GigaBank.Context
{
    public class ContextModel: DbContext
    {
        public DbSet<ContaCorrente> ContaCorrentes { get; set; }

        public ContextModel(DbContextOptions<ContextModel> options)
            : base(options)
        {
            
        }
    }
}