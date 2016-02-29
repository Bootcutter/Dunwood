using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace DunwoodCrossing.Classes
{
  public class Karachter
  {
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual string Background { get; set; }
    public virtual string Strength { get; set; }
    public virtual string Dexterity { get; set; }
    public virtual string Constitution { get; set; }
    public virtual string Intelligence { get; set; }
    public virtual string Wisdom { get; set; }
    public virtual string Charisma { get; set; }
    public virtual string Hitpoints { get; set; }
    public virtual string Quote { get; set; }
    public virtual string FileName {get; set;}
    public virtual string SquareFileName {get; set;}
    
   public virtual string Description {get; set;}
    
  }
}