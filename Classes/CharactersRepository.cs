using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace DunwoodCrossing.Classes
{
  public class KarachtersRepository : IKarachtersRepository
  {
    private KarachtersContext _context;
    public KarachtersRepository(KarachtersContext context)
    {
      _context = context;
    }

    public Karachter GetKarachterByNameAsync(string Karachtername)
    {
        var lowercaseName = Karachtername.ToLowerInvariant();
        return _context.Karachters
        .Where(ch=> ch.Name.ToLowerInvariant() == lowercaseName)
        .FirstOrDefault();
    }
    
    public IEnumerable<Karachter> GetAllKarachters()
    {
      return _context.Karachters
        .ToList();
    }

  public Karachter GetKarachterById(int id)
    {
        return _context.Karachters
        .Where(ch=> ch.Id == id)
        .FirstOrDefault();
    }
    public bool DeleteKarachter(int id)
    {
        var data = GetKarachterById(id);
      _context.Karachters.Remove(data);

      return ( _context.SaveChanges() > 0);
    }
    
    public  bool AddKarachterAsync(Karachter newKarachter)
    {
      _context.Karachters.Add(newKarachter);

      return (_context.SaveChanges() > 0);
    }

    public bool UpdateKarachterAsync(Karachter Karachter)
    {
      _context.Karachters.Update(Karachter);

      return ( _context.SaveChanges() > 0);
    }

  
  }
}
