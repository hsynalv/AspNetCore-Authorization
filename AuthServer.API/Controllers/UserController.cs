﻿using AuthServer.Core.DTOs;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthServer.API.Controllers
{
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            return ActionResultInstance(await _userService.CreateUserAsync(createUserDto));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return ActionResultInstance(await _userService.GetUserByNameAsync(HttpContext.User.Identity.Name));
        }

        [HttpPost("{userName}")]
        public async Task<IActionResult> CreateUserRoles(string userName)
        {
            return ActionResultInstance(await _userService.CreateUserRoles(userName));
        }
    }
}
