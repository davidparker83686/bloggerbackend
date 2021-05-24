using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bloggerbackend.Models;
using bloggerbackend.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bloggerbackend.Controllers
{

  [ApiController]
  [Route("[controller]")]
  [Authorize]
  public class AccountsController : ControllerBase
  {
    private readonly AccountsService _service;
    private readonly BlogsService _blogsService;
    public AccountsController(AccountsService service, BlogsService blogsService)
    {
      _service = service;
      _blogsService = blogsService;
    }

    [HttpGet]
    public async Task<ActionResult<Account>> Get()
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        Account currentUser = _service.GetOrCreateAccount(userInfo);
        return Ok(currentUser);
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpGet("blogs")]
    public async Task<ActionResult<IEnumerable<Blog>>> GetMyBlogs()
    {
      Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
      IEnumerable<Blog> blogs = _blogsService.GetByCreatorId(userInfo.Id);
      return Ok(blogs);

    }




  }
}