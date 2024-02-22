using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Projetinho_Luvi.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api")]
    [ApiController]

    //[Authorize]
    public abstract class BaseController : ControllerBase
    { 
    }
}
