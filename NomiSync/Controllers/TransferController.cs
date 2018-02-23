using NomiSync.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace NomiSync.Controllers
{
    [Route("TransferProcessed/Nomipaq")]
    public class TransferProcessedController : ApiController
    {
        // GET: api/Nomipaq

        public async Task<string> Get()
        {
            return await Nomipaq.Transfer(true);

        }

    }
    [Route("TransferNotProcessed/Nomipaq")]
    public class TransferNotProcessedController : ApiController
    {
        // GET: api/Nomipaq

        public async Task<string> Get()
        {
            return await Nomipaq.Transfer();

        }

    }
}
