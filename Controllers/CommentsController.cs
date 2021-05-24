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
  public class CommentsController
  {
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
      private readonly CommentsService _commentsService;

      public CommentsController(CommentsService commentsService, CommentsService commentsService)
      {
        _commentsService = commentsService;

      }
    }
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Comment>> Create([FromBody] Comment newComment)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<Comment>> Delete(int id)
    {
      try
      {

      }
      catch
      {

      }
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<Comment>> Edit(int id)
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