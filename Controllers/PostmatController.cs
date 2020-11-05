using System.Threading.Tasks;
using DeliveryToPostamt.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryToPostamt.Controllers
{
    [ApiController]
    [Route("api/postmat/")]
    public class PostmatController : ControllerBase
    {
        private readonly IPostmatService _postmatService;      
        public PostmatController(IPostmatService _postmatService)
        {
             this._postmatService = _postmatService;
        }

   /*      [HttpGet("echo/{echo}")]
        public IActionResult echo(string echo)
        {           
            return Ok(echo);          
        } */

       [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var postmat = _postmatService.Get(id);
            if(postmat == null) {
                return NotFound();
            } 
            return Ok(postmat);           
        }      
    }
}