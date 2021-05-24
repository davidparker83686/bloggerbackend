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
  public class BlogsController
  {
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
      private readonly BlogsService _blogsService;
      private readonly CommentsService _commentsService;
      public BlogsController(BlogsService blogsService, CommentsService commentsService)
      {
        _blogsService = blogsService;
        _commentsService = commentsService;
      }
    }


    [HttpGet]
    public ActionResult<IEnumerable<Blog>> GetAll()
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpGet("{id}")]
    public ActionResult<Blog> GetById(int id)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpGet("{id/comments}")]
    public ActionResult<Blog> GetById(int id)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Blog>> Create([FromBody] Blog newBlog)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<Blog>> Delete(int id)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<Blog>> Edit(int id)
    {
      try
      {

      }
      catch
      {

      }
    }


  }
}