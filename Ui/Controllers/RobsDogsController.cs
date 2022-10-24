using System.Web.Mvc;
using Ui.Interfaces;
using Ui.ViewModelMappers;

namespace Ui.Controllers
{
    public class RobsDogsController : Controller
    {
        private readonly IDogOwnerService _dogOwnerService;

        public RobsDogsController(IDogOwnerService dogOwnerService)
        {
            _dogOwnerService = dogOwnerService;
        }

        // GET: RobsDogs
        public ActionResult Index()
        {
			var dogOwnerViewModelMapper = new DogOwnerViewModelMapper(_dogOwnerService);
	        var dogOwnerListViewModel = dogOwnerViewModelMapper.GetAllDogOwners();

            return View(dogOwnerListViewModel);
        }
    }
}