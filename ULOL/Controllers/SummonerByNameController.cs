using Newtonsoft.Json;
using System.Web.Mvc;
using ULOL.Models.APICalls;
using ULOL.Models.APICalls.SummonerByNameV4;


namespace ULOL.Controllers
{
    public class SummonerAPIController : Controller
    {
        // GET: SummonerByName

        public ActionResult Index()
        {
            SummonerByNameV4Model qwe = JsonConvert.DeserializeObject<SummonerByNameV4Model>(new WebApiCall().CallSummonerV4ByName("j0rt"));
            return View(qwe);
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            SummonerByNameV4Model qwe = JsonConvert.DeserializeObject<SummonerByNameV4Model>(new WebApiCall().CallSummonerV4ByName(name));
            return View(qwe);
        }
    }
}