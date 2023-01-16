using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreAjax.Models
{
    public class TransactionDBContext: IdentityDbContext<IdentityUser>
    {
        public TransactionDBContext(DbContextOptions<TransactionDBContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }

    }
}
