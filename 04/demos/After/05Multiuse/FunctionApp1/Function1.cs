using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    public static class AddName
    {
        [FunctionName("AddName")]
        [return: Queue("Names")]
        public static async Task<string> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")]HttpRequestMessage req,
            TraceWriter log)
        {
            dynamic data = await req.Content.ReadAsAsync<object>();

            string name = data?.name;

            // Error checking omitted

            return name;
        }
    }
}
