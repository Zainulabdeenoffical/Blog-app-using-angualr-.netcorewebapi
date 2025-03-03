using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WebApplication1.data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blogController : ControllerBase
    {
        private readonly iRepository<blog> _blogrepository;

        public blogController(iRepository<blog> blogrepository)
        {
           _blogrepository = blogrepository;
        }
        [HttpGet]

        public async Task<IActionResult> getAllBlog()
        {

            var getbloglist = await _blogrepository.Getall();

            return Ok(getbloglist);

        }


        [HttpGet("{id}")]

        public async Task<IActionResult> getBlog([FromRoute]int id)
        {
            var getblog = await _blogrepository.GetbyId(id);

            return Ok(getblog);

        }
        [HttpPost]
        public  async Task<IActionResult> Addblog([FromBody] blog Model)
        {
            await _blogrepository.AddAsync(Model);
            await _blogrepository.SavechnagesAsync();

            return Ok(Model);
        }

        [HttpPost("{id}")]

        public async Task<IActionResult> updateblog([FromRoute] int id ,[FromBody] blog Model) 
        {
            var getblog = await _blogrepository.GetbyId(id);

            getblog.Description = Model.Description;

            getblog.Title = Model.Title;

            getblog.images = Model.images;

            getblog.Conetent = Model.Conetent;

            getblog.isfeatured = Model.isfeatured;

             _blogrepository.UpdateAsync(getblog);
             await  _blogrepository.SavechnagesAsync();

            return Ok(Model);

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteBlog([FromRoute] int id)
        {
             await _blogrepository.DeleteAsync(id);
            _blogrepository.SavechnagesAsync();

            return Ok();

        }

        [HttpGet("featured")]

        public async Task<IActionResult> getAllBlogFaturedlist()
        {

            var blog  = await _blogrepository.Getall(x=>x.isfeatured==true);

            return Ok(blog);

        }


    }
}
