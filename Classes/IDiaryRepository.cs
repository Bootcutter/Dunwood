using System.Collections.Generic;
using System.Threading.Tasks;

namespace DunwoodCrossing.Classes
{
  public interface IDiaryRepository
  {
    IEnumerable<DunwoodCrossing.Classes.DiaryPost> GetAllPosts();
       DiaryPost GetDiaryPostById(int id);
    bool DeleteDiaryPost(int id);
    bool AddDiaryPost(DiaryPost newPost);
    bool UpdateDiaryPost(DiaryPost post);
  
  
  
  }
}