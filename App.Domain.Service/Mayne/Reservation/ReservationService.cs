using App.Domain.Core.Mayne.Reservation.Data;
using App.Domain.Core.Mayne.Reservation.Dto;
using App.Domain.Core.Mayne.Reservation.Service;
using App.Domain.Core.Mayne.Result;

namespace App.Domain.Service.Mayne.Reservation
{
	public class ReservationService(IReservationRepository _reservationRepository) : IReservationService
	{
		public async Task<Result> AddReservation(Core.Mayne.Reservation.Entities.Reservation reservation)
		{
			return await _reservationRepository.AddReservation(reservation);
		}

		public async Task<List<ReservationDto>> GetAllReservation()
		{
			return await _reservationRepository.GetAllReservation();	
		}

		public async Task<ReservationDto> GetReservationByCode(int reservationCode)
		{
			return await _reservationRepository.GetReservationByCode(reservationCode);	
		}
	}
}
