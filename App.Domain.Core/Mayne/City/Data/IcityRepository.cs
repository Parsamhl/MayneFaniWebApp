using App.Domain.Core.Mayne.City.Dtos;


namespace App.Domain.Core.Mayne.City.Data
{
    public interface IcityRepository
    {
        Task<List<CityDto>> GetAll();
    }
}
