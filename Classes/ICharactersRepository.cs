using System.Collections.Generic;
using System.Threading.Tasks;

namespace DunwoodCrossing.Classes
{
  public interface IKarachtersRepository
  {
    IEnumerable<DunwoodCrossing.Classes.Karachter> GetAllKarachters();
    Karachter GetKarachterByNameAsync(string Karachtername);
    Karachter GetKarachterById(int id, bool isNoTrack = false);
    bool DeleteKarachter(int id);
    bool AddKarachterAsync(Karachter newKarachter);
    bool UpdateKarachterAsync(Karachter Karachter);
  
  
  
  }
}