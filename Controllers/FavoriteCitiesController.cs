using Microsoft.AspNetCore.Mvc;
using WeatherAppDatabase.Data;
using WeatherAppDatabase.Services;

namespace WeatherAppDatabase.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class FavoriteCitiesController : ControllerBase
    {
    private readonly IFavoritesService favoritesService;

    public FavoriteCitiesController(IFavoritesService favoritesService)
        {
        this.favoritesService = favoritesService;
    }
    }
