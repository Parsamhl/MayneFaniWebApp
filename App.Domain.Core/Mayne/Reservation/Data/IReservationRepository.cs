

using App.Domain.Core.Mayne.Reservation.Entities;
using App.Domain.Core.Mayne.Result;

namespace App.Domain.Core.Mayne.Reservation.Data
{
    public interface IReservationRepository
    {

        Task<Dto.ReservationDto> GetReservationByCode(int reservationCode);
        Task<List<Dto.ReservationDto>> GetAllReservation();
        Task<Result.Result> AddReservation(Entities.Reservation reservation);
        


    }
}
