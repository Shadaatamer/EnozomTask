using EnozomTask.DTOs;

namespace EnozomTask.Reposiotries;

public interface ITripRepository
{
    Task<List<TripDto>> SearchTrips(string from, string to);
}


