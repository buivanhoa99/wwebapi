using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Domain.DTOs;
using MyWebAPI.Models;
using MyWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    
    public class LoginController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IJWTService _jwtAuthenticationManager;
        public LoginController( IAccountService accountService, IJWTService jwt)
        {
            this._jwtAuthenticationManager = jwt;
            this._accountService = accountService;
        }
        [HttpGet("/Accounts")]
        public  ActionResult GetAccounts()
        {
            //return await _context.Accounts.ToListAsync();
            List<Account> x = _accountService.GetAllAccounts();
            return Ok(x);
        }
        

        [HttpPost("/login")]
        [AllowAnonymous]
        public ActionResult Login ([FromBody] LoginDTO account)
        {
            bool isLogin = _accountService.Login(account.Username, account.Password);
            if (isLogin)
            {
                return Ok(_jwtAuthenticationManager.Authenticate(account.Username));
            }
            return BadRequest("Khong tim thay account");
        }

        [HttpPost]
        [Route("/register")]
        [AllowAnonymous]
        public ActionResult Register([FromBody] Account account)
        {
            if (_accountService.Register(account))
            {
                return Ok(account);
            }
            return BadRequest();
        }

    }
}
