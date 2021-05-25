using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiCsino.Model;

namespace MultiCsino.Data
{
    public class MultiCsinoContext : DbContext
    {
        public MultiCsinoContext (DbContextOptions<MultiCsinoContext> options)
            : base(options)
        {
        }

        public DbSet<MultiCsino.Model.Items> Items { get; set; }

        public DbSet<MultiCsino.Model.Staff> Staff { get; set; }
    }
}
