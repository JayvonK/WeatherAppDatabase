using WeatherAppDatabase.Models;

namespace WeatherAppDatabase.Services;

    public interface IFavoritesService
    {
        List<Favorites> GetFavorites();

        string AddFavCity(string city);

        List<Favorites> DeleteFavCity(string city);
    }
