using Application.Physicians;
using Microsoft.AspNetCore.Mvc;

namespace Endpoints.Physicians;

/// <summary>
/// Physician API controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PhysiciansController : ControllerBase
{
    private readonly IPhysicianService _physicianService;

    public PhysiciansController(IPhysicianService physicianService)
    {
        _physicianService = physicianService;
    }
    
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(PhysicianDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPhysicianById(int id)
    {
        var physician = await _physicianService.GetByIdAsync(id);

        if (physician == null)
            return NotFound(new { Message = $"Physician with ID {id} not found" });

        return Ok(physician);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(PhysicianDto), StatusCodes.Status201Created)]
    public async Task<IActionResult> CreatePhysician([FromBody] CreatePhysicianDto physicianDto)
    {
        var createdPhysician = await _physicianService.CreatePhysicianAsync(physicianDto);
        return CreatedAtAction(nameof(GetPhysicianById), new { id = createdPhysician.Id }, createdPhysician);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<PhysicianDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllPhysicians()
    {
        var physicians = await _physicianService.GetAllPhysiciansAsync();
        return Ok(physicians);
    }
}

