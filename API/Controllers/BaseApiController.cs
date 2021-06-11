using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiController]
    // ? [controller] is a place holder that gets replaced with the class name
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}