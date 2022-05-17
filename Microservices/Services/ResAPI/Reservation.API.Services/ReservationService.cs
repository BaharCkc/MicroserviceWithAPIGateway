using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationModel GetReservationByReservationNumber(int ReservationNumber)
        {
            return new ReservationModel()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                RecordDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                ReservationNumber = ReservationNumber
            };
        }
    }
}
