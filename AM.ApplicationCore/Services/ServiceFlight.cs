using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
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
        //public IList<DateTime> GetFlightDates1(string destination)
        //{
        //    List<DateTime> dates = new List<DateTime>();
        //    foreach (Flight f in Flights)
        //    {
        //        if (f.Destination.Equals(destination))
        //        {
        //            dates.Add(f.FlightDate);

        //        }
        //    }
        //    return dates;
        //}
       
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

        //LINQ
        public IList<DateTime> GetFlightDates2(string destination)
        {
            //var query=from f in Flights
            //           where f.Destination == destination
            //           select f.FlightDate;
            // return query.ToList();
            var query = Flights
                        .Where(f => f.Destination == destination)
                        .Select(f=>f.FlightDate);
            return query.ToList();
        }
        public void ShowFlightDetails(Plane plane)
        {
            //var req=from f in Flights
            //        where(f.MyPlane== plane)
            //        select new { f.FlightDate, f.Destination };
            //foreach (var item in req)
            //{
            //    Console.WriteLine(item.Destination+" "+item.FlightDate);
            //}
            var req = Flights
                     .Where(f => f.MyPlane == plane)
                     .Select(f => new { f.FlightDate, f.Destination });
            foreach (var item in req)
            {
               Console.WriteLine(item.Destination+" "+item.FlightDate);
            }
            

        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var req = from f in Flights
            //              // where( f.FlightDate > startDate && f.FlightDate < startDate.AddDays(7)) )
            //          where f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays<7
            //          select f;
            //return req.Count();
            return Flights
                  .Where(f =>  f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7)
                  .Count();


            }
        public double DurationAverage(string destination)
        {
            //var query = from f in Flights
            //            where f.Destination == destination
            //            select f;
            //return query.Average(f=>f.EstimatedDuration);
            var query = Flights
                      .Where(f => f.Destination == destination)
                      .Average(f => f.EstimatedDuration);
            return query;

        }
        public IList<Flight> OrderedDurationFlights()
        {
            //var query = from f in Flights
            //            orderby f.EstimatedDuration descending
            //            select f;
            //return query.ToList();
            return Flights
                .OrderByDescending(f => f.EstimatedDuration).ToList();
        }
        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            //var query= (from f in Flights
            //           where f.FlightId== flight.FlightId
            //           select f).Single();
            return flight.PassengerList
                .OfType<Traveller>()
                .OrderBy(p=>p.BirthDate).Take(3).ToList();
        }
        public IList<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
                 var req=  Flights
                            .GroupBy(f => f.Destination).ToList();
            foreach (var item in req)
            {   
                Console.WriteLine("Destination :"+item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine("Décollage:"+item2.FlightDate);
                }
            }
            return req;
        }
        /*Délgué pour appele n'importe quel fonction*/
       public Action<Plane> FlightDetailsDel;
       public Func<string, double> DurationAverageDel;

        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //public ServiceFlight()
        //{
        //    FlightDetailsDel = (plane)=>
        //{
        //        var req = Flights
        //                 .Where(f => f.MyPlane == plane)
        //                 .Select(f => new { f.FlightDate, f.Destination });
        //        foreach (var item in req)
        //        {
        //            Console.WriteLine(item.Destination + " " + item.FlightDate);
        //        }


        //    };
        //    DurationAverageDel = destination=>
        //                   Flights
        //                  .Where(f => f.Destination == destination)
        //                  .Average(f => f.EstimatedDuration);

        //}

    }
}
