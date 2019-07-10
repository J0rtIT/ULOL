using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using ULOL.Models.APICalls;
using ULOL.Models.APICalls.StatusV3;

namespace ULOL.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        public async Task<ActionResult> Index()
        {
            var text = await new WebApiCall().CallStatusV3();
            Status qwe = JsonConvert.DeserializeObject<Status>(text);
            return View(qwe);
        }
    }
}