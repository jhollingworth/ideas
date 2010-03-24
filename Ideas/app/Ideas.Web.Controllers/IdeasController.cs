using System.Web.Mvc;
using System.Linq;
using Ideas.Core;
using Ideas.Web.Controllers.ViewModels.Ideas;
using SharpArch.Core.PersistenceSupport;

namespace Ideas.Web.Controllers
{
    public class IdeasController : Controller
    {
        private readonly IRepository<Idea> _ideas;

        public IdeasController(IRepository<Idea> ideas)
        {
            _ideas = ideas;
        }

        public ActionResult Index()
        {
            return View(new IdeasViewModel {Ideas = _ideas.GetAll().ToList()} );    
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Add(AddIdeaViewModel viewModel)
        {
            var idea = new Idea {Name = viewModel.Name, Text = viewModel.Text};

            _ideas.SaveOrUpdate(idea);
            _ideas.DbContext.CommitChanges();
            return RedirectToAction("Index");
        }
    }
}