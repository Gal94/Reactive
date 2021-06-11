using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
  public class ActivitiesController : BaseApiController
  {
    private readonly DataContext _context;

    public ActivitiesController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    // ? the await keyword returns a task of action result that is a list of activities
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        // ? Return all activities
        return await _context.Activities.ToListAsync();
    }

    // ? The url will look like xyz:PORT/api/activities/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
        return await _context.Activities.FindAsync(id);
    }
  }
}