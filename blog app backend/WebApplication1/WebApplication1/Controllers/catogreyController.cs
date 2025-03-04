using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class catogreyController : ControllerBase
    {
        private readonly iRepository<catogries> _repository;

        public catogreyController(iRepository<catogries> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task <IActionResult> GetAllCatogrey()
        {
            var catogreyLiat = await _repository.Getall();

            return Ok(catogreyLiat);
        }



    }
}
