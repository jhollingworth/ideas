using System.Collections.Generic;
using Ideas.Core;

namespace Ideas.Web.Controllers.ViewModels.Ideas
{
    public class IdeasViewModel
    {
        public IdeasViewModel()
        {
            Ideas = new List<Idea>();
        }
        public List<Idea> Ideas { get; set; }
    }
}