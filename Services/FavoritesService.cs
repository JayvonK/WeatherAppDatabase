
using Microsoft.EntityFrameworkCore;
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
        
        _data.Add(fav);
        _data.SaveChanges();

        return _data.Favorites.ToQueryString();
    }

    public List<Favorites> DeleteFavCity(string city)
    {
        var existingCity = _data.Favorites.FirstOrDefault(cityName => cityName.City == city);

        if(existingCity != null)
        {
            _data.Favorites.Remove(existingCity);
            _data.SaveChanges();
        }
        return _data.Favorites.ToList();
    }

}
