using EnozomTask.DTOs;
using EnozomTask.Models;

namespace enzomtask.Services;



public interface ITripService
{
    Task<List<TripDto>> SearchTrips(string from, string to);
}