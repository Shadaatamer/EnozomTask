using EnozomTask.Application.DTO;

namespace EnozomTask.Application.Services;

public interface ITripService
{
    Task<List<TripDto>> SearchTrips(string from, string to);
}