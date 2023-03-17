using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        public int SeatId{ get; set; }
        [Required(ErrorMessage ="PLZ ENTER NAME"),MinLength(1)]
        public string Name { get; set;}
        public string SeatNumber { get; set;}
        [Range(0,20)]
        public int Size { get; set;}
        [ForeignKey(nameof(Plane))]
        public int PlaneFK { get; set;}
        public virtual Plane Plane { get; set;}
        [ForeignKey(nameof(Section))]
        public int? SectionFK { get; set;}
        public virtual Section? Section { get; set;}
        public virtual IList<Reservation> Reservations{ get; set;}
    }
}
