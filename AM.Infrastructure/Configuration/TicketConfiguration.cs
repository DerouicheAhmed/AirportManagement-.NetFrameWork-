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
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new
            {
                t.PassengerFK,
                t.FlightFK
            });
            builder.HasOne(t => t.passengerProp)
                   .WithMany(p => p.TicketList)
                   .HasForeignKey(f => f.PassengerFK);
            builder.HasOne(t => t.flightProp)
                   .WithMany(p => p.TicketList)
                   .HasForeignKey(f => f.FlightFK);
            
        }
    }
}
