using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace DunwoodCrossing.Classes
{
  public class DiaryPost
  {
    public virtual int Id { get; set; }
    
    public virtual int UserId{ get; set;}
    public virtual string Title { get; set; }
    public virtual string Main { get; set; }
    public virtual string Date { get; set; }
   
    
  }
}