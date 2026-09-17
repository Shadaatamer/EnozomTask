namespace EnozomTask.Models;

public class TripStop
{
    public int TripId { get; set; }
    public Trip Trip { get; set; } = null!;

    public int StationId { get; set; }
    public Station Station { get; set; } = null!;

    public TimeSpan Time { get; set; }
    public int StopOrder { get; set; }
}