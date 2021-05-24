using System;
using System.Collections.Generic;
using bloggerbackend.Models;
using bloggerbackend.Repositories_;

namespace bloggerbackend.Services
{
  public class BlogsService
  {
    private readonly BlogsRepository _repo;

    public BlogsService(BlogsRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Blog> GetByCreatorId(string id)
    {
      return _repo.GetByCreatorId(id);
    }
  }
}