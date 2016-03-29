using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DunwoodCrossing.Classes;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;
using System.IO;
using DunwoodCrossing.ViewModels;

namespace DunwoodCrossing.Controllers
{
    public class DiaryController : Controller
    {

 private IKarachtersRepository _repository;
    private IDiaryRepository _diaryRepository;
 
    private IHostingEnvironment _environment;
    public DiaryController(IHostingEnvironment environment, IKarachtersRepository repository, IDiaryRepository diaryRepository)
    {
        _repository = repository;
        _environment = environment;
        _diaryRepository = diaryRepository;
    }

        public IActionResult Index()
        {
            var model = new DunwoodCrossing.ViewModels.DiaryViewModel();
            var data =  _diaryRepository.GetAllPosts();
            var characterIds = data.Select(post => post.UserId).Distinct();
            var characters = _repository.GetAllKarachters().ToList().Where(cha =>characterIds.Contains(cha.Id)).ToDictionary(cha => cha.Id, cha => cha);
            var posts = data.Select(post => {
              var diaryPost = new DiaryPostViewModel()
              {
                  Post = post,
                  Name = characters.ContainsKey(post.UserId) ? characters[post.UserId].Name : "Unknown",
                  ImageUrl = characters.ContainsKey(post.UserId) ? characters[post.UserId].FileName : ""
              };
              return diaryPost;
            });
            model.DiaryPosts = posts;
            ViewData["Message"] = "Characters";

            return View(model);
        }

 [HttpPost]
public IActionResult InsertNewPost(string post, string title, string date, int characterId)
{
    var newPost = new DiaryPost()
    {
       UserId = characterId,
       Main = post,
       Title = title,
       Date = date
    };
   _diaryRepository.AddDiaryPost(newPost);
   return RedirectToAction("Index");
}
        public IActionResult Log()
        {
            ViewData["Message"] = "Log of Events";
            return View();
        }

    }
   
}
