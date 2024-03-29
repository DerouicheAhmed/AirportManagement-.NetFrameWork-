﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string? Pilot { get; set; }


        public int EstimatedDuration { get; set; }
       // [ForeignKey("PlaneID")]
        public virtual Plane? MyPlane { get; set; }
        public virtual ICollection<Passenger> PassengerList { get; set; }
        public virtual IList<Ticket> TicketList { get; set; }

        [ForeignKey("MyPlane")]
        public int? PlaneID { get; set; }
           
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}";
        }
    }
}
