using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DunwoodCrossing.Classes;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;
using System.IO;

namespace DunwoodCrossing.Controllers
{
    public class HomeController : Controller
    {

 private IKarachtersRepository _repository;
    
    private IHostingEnvironment _environment;
    public HomeController(IHostingEnvironment environment, IKarachtersRepository repository)
    {
      _repository = repository;
      _environment = environment;
    }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Log()
        {
            ViewData["Message"] = "Log of Events";

            return View();
        }

        public IActionResult Characters()
        {
            var model = new DunwoodCrossing.ViewModels.KarachtersViewModel();
            var data =  _repository.GetAllKarachters().ToList();
           model.Karachters = data;
            ViewData["Message"] = "Characters";

            return View(model);
        }
        
          public IActionResult AddCharacter()
        {
           

            return View();
        }


         public IActionResult DeleteCharacter(int id)
        {
           var data = _repository.GetKarachterById(id);
           

            return View(data);
        }


 [HttpPost]
    public ActionResult AddKarachterPost(DunwoodCrossing.Classes.Karachter newKarachter, IFormFile file, IFormFile filesquare)
    {
    
              var uploads = Path.Combine(_environment.WebRootPath,"uploads"); 
               if(file != null && file.Length>0)
               {
                 var fileName = Microsoft.Net.Http.Headers.ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                 file.SaveAs(Path.Combine(uploads,fileName));
                 newKarachter.FileName = "~/uploads/" + fileName;
               } 
                  if(filesquare != null && filesquare.Length > 0)
               {
                 var fileSquareName = Microsoft.Net.Http.Headers.ContentDispositionHeaderValue.Parse(filesquare.ContentDisposition).FileName.Trim('"');
                 filesquare.SaveAs(Path.Combine(uploads,fileSquareName));
                 newKarachter.SquareFileName = "~/uploads/" +fileSquareName;
               }
              
              
               
      if ( _repository.AddKarachterAsync(newKarachter))
      {
        
      }

      return RedirectToAction("Characters");
    }

 [HttpPost]
    public ActionResult DeleteKarachterPost(int id)
    {
    
              _repository.DeleteKarachter(id);
       

      return RedirectToAction("Characters");
    }

        public IActionResult Error()
        {
            return View();
        }
    }
}
