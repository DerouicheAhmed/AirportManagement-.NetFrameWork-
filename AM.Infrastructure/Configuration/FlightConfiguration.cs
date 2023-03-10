using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("MyFlight");
            builder.HasKey(f => f.FlightId);

            builder.HasOne(f => f.MyPlane)
                   .WithMany(p => p.Flights)
                   .HasForeignKey(f => f.PlaneID)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(f => f.PassengerList)
                   .WithMany(f => f.FlightList)
                   .UsingEntity(f => f.ToTable("MyReservation"));
        }
    }
}
