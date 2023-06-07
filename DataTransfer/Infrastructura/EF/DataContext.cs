using Microsoft.EntityFrameworkCore;
using DataTransfer.Application.Models;

namespace DataTransfer.Infrastructura.EF
{
    public class DataContext : DbContext
    {
        internal DataContext()
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DataSet> DataSets { get; set; }
        public DbSet<DataSource> DataSources { get; set; }
        public DbSet<DataTransferStatus> DataTransferStatuses  { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        

    }
}
