using iSawah.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FieldOwner> FieldOwners { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
