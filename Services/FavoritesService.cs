
using WeatherAppDatabase.Data;
using WeatherAppDatabase.Models;

namespace WeatherAppDatabase.Services;

public class FavoritesService : IFavoritesService
{
    private readonly DataContext _data;

    public FavoritesService(DataContext data)
    {
        _data = data;
    }

    public string AddFavCity(string city)
    {
        Favorites fav = new();
        fav.City = city;
        return _data.Favorites.ToString();
    }

    public string DeleteFavCity(string city)
    {
        throw new NotImplementedException();
    }

}
