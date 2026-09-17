

namespace EnozomTask.Domain.Models;

public class Trip
{
    public int TripNumber { get; set; }

    public int TrainId { get; set; }
    public Train Train { get; set; } = null!;

    public ICollection<TripStop> TripStops { get; set; }
        = new List<TripStop>();
}