using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {
        
        public DateTime DateReservation { get; set; }
        public virtual Seat seatProp { get; set; }
        public virtual Passenger passengerProp { get; set; }
        [ForeignKey(nameof(seatProp))]
         public int SeatFK { get; set; }
         public int PassengerFK { get; set; }    }
}
