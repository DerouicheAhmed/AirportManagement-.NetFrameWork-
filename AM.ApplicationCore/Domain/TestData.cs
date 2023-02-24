using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane p1 = new Plane
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManufactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane p2 = new Plane
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManufactureDate = new DateTime(2020, 11, 11)
        };
        public static Staff staff1 = new Staff
        {
            FirstName = "Captain",
            LastName = "Captain",
            EmailAddress = "Captain.captain@gamil.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmploymentDate = new DateTime(1999, 01, 01),
            Salary = 99999
        };
        public static Staff staff2 = new Staff
        {
            FirstName = "hostess1",
            LastName = "hostess1",
            EmailAddress = "hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        public static Staff staff3 = new Staff
        {
            FirstName = "hostess2",
            LastName = "hostess2",
            EmailAddress = "hostess2.hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        public static Traveller traveller1 = new Traveller
        {
            FirstName = "traveller1",
            LastName = "traveller1",
            EmailAddress = "traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "American"

        };
        public static Traveller traveller2 = new Traveller
        {
            FirstName = "traveller2",
            LastName = "traveller2",
            EmailAddress = "traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "French"

        };
        public static Traveller traveller3 = new Traveller
        {
            FirstName = "traveller3",
            LastName = "traveller3",
            EmailAddress = "traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "Tunisian"

        };
        public static Traveller traveller4 = new Traveller
        {
            FirstName = "traveller4",
            LastName = "traveller4",
            EmailAddress = "traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "American"

        };
        public static Traveller traveller5 = new Traveller
        {
            FirstName = "traveller5",
            LastName = "traveller5",
            EmailAddress = "traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "Spanich"

        };
        public static Flight flight1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p2,
            EstimatedDuration = 110,
            PassengerList = new List<Passenger>()
            {
                traveller1,traveller2,traveller3,traveller4,traveller5
            }

        };
        public static Flight flight2 = new Flight
        {
            FlightDate = new DateTime(2022, 02, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01),
            MyPlane = p1,
            EstimatedDuration = 105,


        };
        public static Flight flight3 = new Flight
        {
            FlightDate = new DateTime(2022, 03, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01),
            MyPlane = p1,
            EstimatedDuration = 100,


        };
        public static Flight flight4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01),
            MyPlane = p1,
            EstimatedDuration = 130,


        };
        public static Flight flight5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01),
            MyPlane = p1,
            EstimatedDuration = 105,


        };
        public static Flight flight6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01),
            MyPlane = p2,
            EstimatedDuration = 200,

        };
        public static List<Flight> listFlights = new List<Flight>
        {
           flight1,flight2,flight3,flight4,flight5,flight6
        };
    }
}

