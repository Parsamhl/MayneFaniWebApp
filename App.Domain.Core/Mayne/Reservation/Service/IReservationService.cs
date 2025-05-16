
namespace App.Domain.Core.Mayne.Reservation.Service
{
	public interface IReservationService
	{
		Task<Dto.ReservationDto> GetReservationByCode(int reservationCode);
		Task<List<Dto.ReservationDto>> GetAllReservation();
		Task<Result.Result> AddReservation(Entities.Reservation reservation);
	}
}
