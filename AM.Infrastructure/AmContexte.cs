using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;

namespace AM.Infrastructure
{
    public class AmContexte:DbContext
    {
        public DbSet<Flight> Flights{ get;set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source =(localdb)\mssqllocaldb; initial catalog =ahmedderouiche; integrated security= true");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            //Stratègie d'héritage TPT :
            //modelBuilder.Entity<Passenger>().ToTable(nameof(Passenger));
            //modelBuilder.Entity<Staff>().ToTable(nameof(Staff));
            //modelBuilder.Entity<Traveller>().ToTable(nameof(Traveller));
            //fin strategie


            

            //modelBuilder.Entity<Passenger>().Property(f => f.FirstName)
            //                                                         .HasColumnName("PassengerName")
            //                                                         .HasMaxLength(30)
            //                                                         .IsRequired()
            //                                                         .HasColumnType("varchar");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar")
                                                     .HaveMaxLength(50);

            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<double>().HavePrecision(2,3);

        }
    }
}
