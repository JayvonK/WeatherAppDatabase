using Microsoft.AspNetCore.Mvc;
using WeatherAppDatabase.Models;
using WeatherAppDatabase.Services;

namespace WeatherAppDatabase.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class FavoriteCitiesController : ControllerBase
    {
    private readonly IFavoritesService _favoritesService;

    public FavoriteCitiesController(IFavoritesService favoritesService)
        {
        _favoritesService = favoritesService;
    }

    [HttpGet]
    [Route("GetFavorites")]
    public List<Favorites> GetFavorites()
    {
        return _favoritesService.GetFavorites();
    }

    [HttpPost]
    [Route("AddCity/{cityName}")]

    public List<Favorites> AddFavCity(string cityName)
    {
        return _favoritesService.AddFavCity(cityName);
    }

    [HttpDelete]
    [Route("DeleteCity/{cityName}")]

    public List<Favorites> DeleteCity(string cityName)
    {
        return _favoritesService.DeleteFavCity(cityName);
    }

    }
