using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace RemMonitor
{
    class LogContext : DbContext
    {
        public DbSet<LogDB> LogsDB { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=RemittanceRefresh.monitor;Trusted_Connection=True;");
        }
    }
}
