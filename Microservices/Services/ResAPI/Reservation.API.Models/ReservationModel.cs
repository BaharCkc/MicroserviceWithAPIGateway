using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        public int ReservationNumber { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? RecordDate { get; set; }
        public double Amount { get; set; }
    }
}
