using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DunwoodCrossing.Classes;
using Microsoft.Data.Entity;
namespace DunwoodCrossing.Classes
{
public class KarachtersContext : DbContext
    {
  public KarachtersContext()
  {
     
  }
 
  public DbSet<Karachter> Karachters { get; set; }
 
  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Karachter>().HasKey(v => v.Id);
 
    base.OnModelCreating(builder);
  }
}
}