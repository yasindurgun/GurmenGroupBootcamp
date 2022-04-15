using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week3.AOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        GetListWithAspectService s;
        public StudentsController()
        {
            s = new GetListWithAspectService();
        }
        [HttpGet]
        public IActionResult Get()
        {
            //Console.WriteLine("controller");
            return Ok(s.GetList());
        }
    }
}
