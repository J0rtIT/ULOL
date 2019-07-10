using Newtonsoft.Json;
using System.Web.Mvc;
using ULOL.Models.APICalls;
using ULOL.Models.APICalls.SpectatorV4;

namespace ULOL.Controllers
{
    public class SpectatorFeaturedController : Controller
    {
        // GET: SpectatorFeatured
        public ActionResult Index()
        {
            Featured qwe = JsonConvert.DeserializeObject<Featured>(new WebApiCall().CallSpectatorFeatured());
            return View(qwe);
        }
    }
}