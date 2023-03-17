using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP{ get; set; }
        public string Siege { get; set; }
        public double prix { get; set; }
        public virtual Passenger passengerProp { get; set; }    
        public virtual Flight flightProp { get; set; }
        //[ForeignKey(nameof(flightProp))]
        public int FlightFK { get; set; }
        //[ForeignKey(nameof(passengerProp))]
        public int PassengerFK { get; set; }

    }
}
