using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace DunwoodCrossing.Classes
{
  public class KarachtersRepository : IKarachtersRepository, IDiaryRepository
  {
    private KarachtersContext _context;
    public KarachtersRepository(KarachtersContext context)
    {
      _context = context;
    }

    public IEnumerable<DiaryPost> GetAllPosts()
    {
        return _context.Posts;
    }
    
    
    
      public  bool AddDiaryPost(DiaryPost newPost)
    {
      _context.Posts.Add(newPost);

      return (_context.SaveChanges() > 0);
    }

    public bool UpdateDiaryPost(DiaryPost post)
    {
      _context.Posts.Update(post);

      return ( _context.SaveChanges() > 0);
    }
public DiaryPost GetDiaryPostById(int id)
{
   return _context.Posts.FirstOrDefault(post => post.Id == id);
}

  public  bool DeleteDiaryPost(int id)
    {
        var post = GetDiaryPostById(id);
      _context.Posts.Remove(post);

      return (_context.SaveChanges() > 0);
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

  public Karachter GetKarachterById(int id, bool isNoTrack = false)
    {
        var query = _context.Karachters.Where(ch=> ch.Id == id);
        if(isNoTrack)
        {
            query = query.AsNoTracking();
        }
        return query
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
        
        var oldCharacter = GetKarachterById(Karachter.Id, true);
        if(string.IsNullOrEmpty(Karachter.FileName))
        {
            Karachter.FileName = oldCharacter.FileName;
            }
       if(string.IsNullOrEmpty(Karachter.SquareFileName))
        {
            Karachter.SquareFileName = oldCharacter.SquareFileName;
            }

      _context.Karachters.Update(Karachter);

      return ( _context.SaveChanges() > 0);
    }

  
  }
}
