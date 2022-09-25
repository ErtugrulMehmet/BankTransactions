using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDnContext:DbContext
    {
        public TransactionDnContext(DbContextOptions<TransactionDnContext> options):base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
