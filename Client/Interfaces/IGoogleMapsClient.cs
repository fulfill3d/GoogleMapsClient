using Client.Models;

namespace Client.Interfaces
{
    public interface IGoogleMapsClient
    {
        Task<Location?> GetCoordinatesAsync(GeocodingRequest request);
    }
}