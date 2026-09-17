using EnozomTask.Data;
using EnozomTask.Models;
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

    public async Task<List<Trip>> SearchTrips(string from, string to)
    {
        return await _context.Trips
            .Include(t => t.Train)
            .Include(t => t.TripStops)
                .ThenInclude(ts => ts.Station)
            .Where(t =>
                t.TripStops.Any(s => s.Station.Name == from) &&
                t.TripStops.Any(s => s.Station.Name == to))
            .AsNoTracking()
            .ToListAsync();
    }
}