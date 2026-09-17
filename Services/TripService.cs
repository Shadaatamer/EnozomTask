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
        var trips = await _tripRepository.SearchTrips(from, to);

        var result = new List<TripDto>();

        foreach (var trip in trips)
        {
            var fromStop = trip.TripStops
                .FirstOrDefault(s => s.Station.Name == from);

            var toStop = trip.TripStops
                .FirstOrDefault(s => s.Station.Name == to);

            if (fromStop == null || toStop == null)
                continue;

            if (from == to)
            {
                if (fromStop.StopOrder == 1)
                {
                    result.Add(new TripDto
                    {
                        TripNumber = trip.TripNumber,
                        TrainName = trip.Train.Name
                    });
                }

                continue;
            }

            if (fromStop.StopOrder < toStop.StopOrder)
            {
                result.Add(new TripDto
                {
                    TripNumber = trip.TripNumber,
                    TrainName = trip.Train.Name
                });
            }
        }

        return result;
    }
}
