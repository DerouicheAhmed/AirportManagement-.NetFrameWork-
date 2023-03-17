    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing, Airbus
    };
    public class Plane

    {
        [Range(0,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        [ForeignKey("PlaneId")]
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual IList<Seat> Seats { get; set; }
        public Plane() { }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }

    }
}
