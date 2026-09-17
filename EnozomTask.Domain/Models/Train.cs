
namespace EnozomTask.Domain.Models;

public class Train
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Trip> Trip { get; set; } = new List<Trip>();
}