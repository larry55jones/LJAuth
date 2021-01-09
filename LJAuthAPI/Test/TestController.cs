using Microsoft.AspNetCore.Mvc;

namespace LJAuthAPI.Test
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("{input}")]
        public string Test(string input)
        {
            return input;
        }
    }
}
