namespace WeatherAppDatabase.Services;

    public interface IFavoritesService
    {
        string AddFavCity(string city);

        string DeleteFavCity(string city);
    }
