using invoice_back.DomainObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace invoice_back.Models
{
    public class ContextInv : DbContext
    {
        public ContextInv()
        {

        }

        public ContextInv(DbContextOptions<ContextInv> options) : base(options)
        {

        }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<UOM> UOM { get; set; }
        public virtual DbSet<Number> Number { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<InvHeader> InvHeader { get; set; }
        public virtual DbSet<InvDetail> InvDetail { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = localhost\SQLEXPRESS; Database = project_klbf; User Id = admin; Password = admin123; Connect Timeout = 900; ");
            }
        }

    }
}
