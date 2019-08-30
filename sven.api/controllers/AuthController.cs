using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sven.business;
using sven.business.models;
using sven.business.middleware;
using Microsoft.AspNetCore.Authorization;
using sven.models;
using sven.models.access;

namespace sven.api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private SvenDbContext _context;

        private AuthBusiness _business;

        public AuthController(SvenDbContext context)
        {
            _business = new AuthBusiness(_context = context);
        }

        [HttpGet]
        public BaseModel Index([FromHeader] string authenticationCookie)
        {
            _business.Validate(authenticationCookie);

            return _business.Model;
        }

        [Authorize]
        [HttpPost]
        public string Login([FromQuery] string name)
        {
            return "Hello " + name;
        }
    }
}