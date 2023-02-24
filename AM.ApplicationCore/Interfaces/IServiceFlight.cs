using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public  interface IServiceFlight
    {
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        IList<DateTime> GetFlightDates2(string destination);
        public void ShowFlightDetails(Plane plane);
       public int  ProgrammedFlightNumber(DateTime startDate);
       public double DurationAverage(string destination);
        public IList<Flight>OrderedDurationFlights();
        public IList<Traveller> SeniorTravellers(Flight flight);
        public IList<IGrouping<string, Flight>> DestinationGroupedFlights();


    }
}
