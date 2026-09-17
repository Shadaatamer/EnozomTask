
using EnozomTask.Application.DTO;

namespace EnozomTask.Application.Repositories;

public interface ITripRepository
{
    Task<List<TripDto>> SearchTrips(string from, string to);
}


