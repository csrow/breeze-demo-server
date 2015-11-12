namespace BzDemo1
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class BzDemoContext : DbContext
  {
    public BzDemoContext()
        : base("name=BzDemoContext")
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Detail> Details { get; set; }
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<Order> Orders { get; set; }

  }
}
