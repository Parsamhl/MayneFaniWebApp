using App.Domain.Core.Mayne.Connection;
using App.Domain.Core.Mayne.Reservation.Data;
using App.Domain.Core.Mayne.Reservation.Dto;
using App.Domain.Core.Mayne.Result;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;

using App.Infra.Db.SqlServer;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repo.Dapper.Mayne.Reservation
{
    public class ReservationRepositoryDapper : IReservationRepository
    {

        string connectrion = Connection.ConnectionString;

        private readonly IDbConnection _context;

        public ReservationRepositoryDapper(IDbConnection context)
        {
            _context = context;
        }

        public async Task<Result> AddReservation(Domain.Core.Mayne.Reservation.Entities.Reservation reservation)
        {
            if (reservation is null)
                return new Result { IsSuccess = false, Message = "Reservation is null" };


            var command = "INSERT INTO Reservations (Date, BaseId, CarId, ReservationCode) VALUES (@Date , @BaseId, @CarId,  @ReservationCode)";

            await _context.ExecuteAsync(command, reservation);

            return new Result { Message = " done", IsSuccess = true };
        }

        public async Task<List<ReservationDto>> GetAllReservation()
        {

            var command = @"SELECT ReservationCode , Date , CarId ,BaseName ,CarPlate ,CarName ّFROM Reservations ORDER BY Date DESC";

            var result = await _context.QueryAsync<ReservationDto>(command);
            return result.ToList();
        }



        public async Task<ReservationDto> GetReservationByCode(int reservationCode)
        {
            var command = @"SELECT ReservationCode , Date , CarId ,BaseName ,CarPlate ,CarName Where ReservationCode = @reservationCode From Reservations ";

            return await _context.QueryFirstOrDefaultAsync<ReservationDto>(command, new { ReservationCode = reservationCode });
        }
    }
}
