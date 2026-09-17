using EnozomTask.DTOs;
using EnozomTask.Models;
using EnozomTask.Reposiotries;
using enzomtask.Services;

namespace EnozomTask.Services;

public class TripService : ITripService
{
    private readonly ITripRepository _tripRepository;

    public TripService(ITripRepository tripRepository)
    {
        _tripRepository = tripRepository;
    }

    public async Task<List<TripDto>> SearchTrips(string from, string to)
    {
        return await _tripRepository.SearchTrips(from, to);


    }
}
