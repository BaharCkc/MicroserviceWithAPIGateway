using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        ReservationModel GetReservationByReservationNumber(int ReservationNumber);
    }
}
