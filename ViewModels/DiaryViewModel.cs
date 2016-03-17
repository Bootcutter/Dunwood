using System;
using System.Collections.Generic;
using DunwoodCrossing.Classes;

namespace DunwoodCrossing.ViewModels
{
    public class DiaryViewModel
    {
        public IEnumerable<DiaryPostViewModel> DiaryPosts { get; set;}
        
    
    }
    public class DiaryPostViewModel
    {
        public DiaryPost Post {get; set;}
        public string Name {get; set;}
        public string ImageUrl {get; set;}
    }
}