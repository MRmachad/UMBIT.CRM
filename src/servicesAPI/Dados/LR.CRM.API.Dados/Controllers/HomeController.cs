using Microsoft.AspNetCore.Mvc;

namespace LR.CRM.API.Dados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
       
        public HomeController()
        {

        }

        [HttpGet("/busca")]
        public async Task<string> Busca()
        {
            var client = new HttpClient();

            var res = await client.GetAsync("https://www.google.com.br/maps/search/escola/@-16.6652008,-49.2497189,15z");

            return await res.Content.ReadAsStringAsync(); 
        }
    }
}
