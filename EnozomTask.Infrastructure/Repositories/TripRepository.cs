
using EnozomTask.Application.DTO;
using EnozomTask.Application.Repositories;
using EnozomTask.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EnozomTask.Infrastructure.Repositories;

public class TripRepository : ITripRepository
{
    private readonly AppDbContext _context;

    public TripRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TripDto>> SearchTrips(string from, string to)
    {
        return await _context.Trips
        .Where(t => t.TripStops.Any(fromStop => fromStop.Station.Name == from &&
                    t.TripStops.Any(toStop =>
                        toStop.Station.Name == to &&
                        fromStop.StopOrder < toStop.StopOrder
                    )
                )
            )
            .Select(t => new TripDto
            {
                TripNumber = t.TripNumber,
                TrainName = t.Train.Name
            })
            .AsNoTracking()
            .ToListAsync();
    }

}