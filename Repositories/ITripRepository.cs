using EnozomTask.Models;

namespace EnozomTask.Reposiotries;

public interface ITripRepository
{
    Task<List<Trip>> SearchTrips(string from, string to);
}


