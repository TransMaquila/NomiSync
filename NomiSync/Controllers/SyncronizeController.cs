using NomiSync.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace NomiSync.Controllers
{
    [Route("Syncronize/Nomipaq")]
    public class SyncronizeController : ApiController
    {
        // GET: api/Nomipaq
        public async Task<string> Get()
        {
            return await Nomipaq.Syncronize();

        }

    }
}
