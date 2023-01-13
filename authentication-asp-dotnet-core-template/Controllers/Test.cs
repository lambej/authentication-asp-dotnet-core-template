using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authentication_asp_dotnet_core_template.Controllers
{
    [Route("api/Test")]
    [Produces("application/json")]
    public class TestController : Controller
    {
        [HttpGet]
        [Authorize]
        public string GetTest()
        {
            return "Test call to api succeed!";
        }
    };
}