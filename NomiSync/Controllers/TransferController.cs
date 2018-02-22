using NomiSync.Models;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;

namespace NomiSync.Controllers
{
    [Route("Transfer/Nomipaq")]
    public class TransferController : ApiController
    {
        // GET: api/Nomipaq
        public async Task<string> Get()
        {
            return await Nomipaq.Transfer();

        }

    }
}
