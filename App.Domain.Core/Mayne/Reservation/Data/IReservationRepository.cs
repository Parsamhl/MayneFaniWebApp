

using App.Domain.Core.Mayne.Reservation.Entities;
using App.Domain.Core.Mayne.Result;

namespace App.Domain.Core.Mayne.Reservation.Data
{
    public interface IReservationRepository
    {

        Task<Entities.Reservation> GetReservationByCode(int reservationCode);
        Task<List<Entities.Reservation>> GetAllReservation();
        Task<Result.Result> AddReservation(Entities.Reservation reservation);
        


    }
}
