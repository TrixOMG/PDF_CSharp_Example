using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfAppSearchBarriers1;

public partial class AppdataContext : DbContext
{
    public AppdataContext()
    {
    }

    //public DbSet<Employee> Employees { get; set; }
    public DbSet<Employee> Table { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Appdata;");
}
