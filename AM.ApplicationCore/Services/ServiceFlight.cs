using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public IList<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination.Equals(destination))
                {
                    dates.Add(Flights[i].FlightDate);

                }
            }
            return dates;
        }
        public IList<DateTime> GetFlightDates1(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Flight f in Flights)
            {
                if (f.Destination.Equals(destination))
                {
                    dates.Add(f.FlightDate);

                }
            }
            return dates;
        }
        public IList<DateTime> GetFlightDates2(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                        {
                            System.Console.WriteLine(f);
                        }
                    }
                    break;
                case "Date":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate.Equals(DateTime.Parse(filterValue)))
                        {
                            System.Console.WriteLine(f);
                        }
                    }
                    break;

                case "EstimatedDuration":
                    foreach (Flight f in Flights)
                    {
                        if (f.EstimatedDuration.Equals(int.Parse(filterValue)))

                            System.Console.WriteLine(f);

                    }
                    break;
            }

        }

       
    }
}
