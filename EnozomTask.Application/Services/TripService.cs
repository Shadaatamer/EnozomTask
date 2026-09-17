using EnozomTask.Application.DTO;
using EnozomTask.Application.Repositories;

namespace EnozomTask.Application.Services;

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
