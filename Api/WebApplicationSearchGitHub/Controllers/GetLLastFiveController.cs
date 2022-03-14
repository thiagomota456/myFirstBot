using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSearchGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetLLastFiveController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public string Get()
        {
            return "Working";
        }

        // GET api/<GetLLastFiveController>/User
        [HttpGet("{User}")]
        public async Task<string> GetAsync(string user)
        {
            client.DefaultRequestHeaders.Add("User-Agent", "request");
            var responseString = await client.GetStringAsync("https://api.github.com/users/" + user + "/repos");
            var repository = JsonConvert.DeserializeObject<List<Repository>>(responseString);

            var fiveLastRepositorys = repository.OrderByDescending(c => c.created_at).TakeLast(5).OrderBy(c => c.created_at).ToList();

            
            return JsonConvert.SerializeObject(fiveLastRepositorys);
        }


    }
}
