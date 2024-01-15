using WeatherAppDatabase.Models;

namespace WeatherAppDatabase.Services;

    public interface IFavoritesService
    {
        string AddFavCity(string city);

        List<Favorites> DeleteFavCity(string city);
    }
