using Microsoft.AspNetCore.Mvc;
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
    [Route("AddCityName/{city}")]

    public string AddFavCity(string city)
    {
        return _favoritesService.AddFavCity(city);
    }

    }
