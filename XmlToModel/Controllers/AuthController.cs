using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XmlToModel.Data;
using XmlToModel.Dtos;
using XmlToModel.Services;

namespace XmlToModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IAuthService _authService;

        public AuthController(DataContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RegisterNewUser(RegisterNewUserDto registerNewUserDto)
        {
            return Ok();
        }
    }
}