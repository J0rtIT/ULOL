using System.Web.Http;
using ULOL.Models.Dtos;

namespace ULOL.Controllers
{
    public class SummonerAPIController : ApiController
    {

        public Summonerv4 GetSummonerInfo(string Summonername)
        {
            return new Summonerv4(Summonername);
        }
    }
}
