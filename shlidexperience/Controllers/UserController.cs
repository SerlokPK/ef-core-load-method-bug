using Common;
using Common.Helpers;
using Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace shlidexperience.Controllers
{
    [Route("api/test")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IOptions<AppSettings> options, IUserService userService) : base(options)
        {
            DependencyHelper.ThrowIfNull(userService);

            _userService = userService;
        }

        [HttpGet("include")]
        public IActionResult IncludeTest()
        {
            return Ok(_userService.GetWithInclude());
        }

        [HttpGet("load")]
        public IActionResult LoadTest()
        {
            return Ok(_userService.GetWithLoad());
        }
    }
}
