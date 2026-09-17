using EnozomTask.Data;
using EnozomTask.DTOs;
using EnozomTask.Reposiotries;
using Microsoft.EntityFrameworkCore;

namespace EnozomTask.Repositories;

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