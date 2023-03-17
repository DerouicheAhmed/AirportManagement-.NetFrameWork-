using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new { r.PassengerFK, r.SeatFK });
            builder.HasOne(reservation => reservation.passengerProp)
                   .WithMany(passenger => passenger.ReservationList)
                   .HasForeignKey(reservation => reservation.PassengerFK);
                   
                   
        }
    }
}
