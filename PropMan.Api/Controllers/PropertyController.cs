using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropMan.Api.Data;

namespace PropMan.Api.Controller;
[ApiController]
[Route("api/[controller]")]
public class  PropertyController: ControllerBase 
{
    private readonly PropManDbContext _context;

    public PropertyController(PropManDbContext context)
    {
         _context = context;
    }

    [HttpGet]
    public async Task<List<Property>> GetProperty()
    {
        return await _context.Properties.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Property>> GetPropertyById(int id)
    {
        var property = await _context.Properties.FindAsync(id);
        if(property is null)
        {
            return NotFound();
        }
        return property;
    }

    
}