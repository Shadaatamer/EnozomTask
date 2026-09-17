using enzomtask.Services;
using Microsoft.AspNetCore.Mvc;

namespace CnozomTask.Contollers;

[ApiController]
[Route("api/[controller]")]
public class TripController : ControllerBase
{
    private readonly ITripService _tripService;

    public TripController(ITripService tripService)
    {
        _tripService = tripService;
    }

    [HttpGet]
    public async Task<IActionResult> SearchTrips([FromQuery] string from, [FromQuery] string to)
    {
        var trips = await _tripService.SearchTrips(from, to);
        if (trips.Count == 0)
        {
            return NotFound("No trips found for the specified stations.");
        }
        return Ok(trips);
    }
}