// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
//string chaine=Console.ReadLine();
//float age=0;
//try
//{
// age = float.Parse(Console.ReadLine());
//}
//catch
//{
//    Console.WriteLine("Erreur");
//}
//Console.WriteLine("Hello"+chaine+"age:"+(age+1));
//Personne p = new Personne();
//p.Id = 0;
//p.Nom = "foulen";
//p.Prenom = "foulen";
//p.Email = "foulen.foulen@gmail.com";
//p.Password= "00000";
//p.DateDeNaissance = DateTime.Now;
//Console.WriteLine(p);
//Personne p1= new Personne("Derouiche","Ahmed","ahmed.derouiche@esprit.tn","1234",DateTime.Now);
//Console.WriteLine(p1);
//Personne p2 = new Personne() { 
//Nom="Abbes",
//Prenom="Malek",
//Email="Malek.abbes@gmail.com",
//Password="111111",
//DateDeNaissance=DateTime.Now
//};
//Console.WriteLine(p2);
//Etudiant etudiant = new Etudiant();
//etudiant.GetMyType();
//p.GetMyType();
//Personne etudiant1 = new Etudiant();
//etudiant1.GetMyType();
//Plane p1 = new Plane();
//p1.Capacity = 300;
//p1.ManufactureDate = new DateTime(1998, 01, 18);
//p1.PlaneType = PlaneType.Airbus;
//Console.WriteLine(p1.ToString());
//Plane p2 = new Plane(PlaneType.Boing, 500, DateTime.Now);
//Console.WriteLine(p2.ToString());

//Plane p3 = new Plane
//{
//    Capacity = 500,
//    PlaneType = PlaneType.Airbus,
//    ManufactureDate = DateTime.Now
//};
//Console.WriteLine(p3.ToString());
//Passenger pass1 = new Passenger
//{
//    FirstName = "Fedi",
//    LastName = "Jellali",
//    EmailAddress = "fedi.jellali@esprit.tn"

//};
//Passenger sf1 = new Staff();
//Passenger tr1 = new Traveller();
//pass1.PassengerType();
//sf1.PassengerType();
//tr1.PassengerType();
//ServiceFlight sf = new ServiceFlight();
//sf.Flights = TestData.listFlights;
//Console.WriteLine("Les Dates des vols à Paris:");
//foreach (var item in sf.GetFlightDates2("Paris"))
//{
//    Console.WriteLine(item);
//}
//sf.GetFlights("Destination", "Madrid");

int x = 45;
x.Add(5);
Console.WriteLine(x.Add(5));
Passenger passenger = new Passenger()
{
    //LastName = "derouiche",
    //FirstName = "ahmed"
};
passenger.UpperFullName();
Console.WriteLine(passenger);
AmContexte contexte = new AmContexte();
//contexte.Flights.Add(new Flight()
//{
//    EffectiveArrival = new DateTime(2023, 03, 17),
//    Departure="Tunis",
//    Destination="Germany",
//    EstimatedDuration=2,
//    FlightDate=new DateTime(2023,03,17),
//    MyPlane=new Plane()
//    {
//        Capacity=30,
//        ManufactureDate=new DateTime(2023,03,22),
//        PlaneType=PlaneType.Boing
//    }



//});
//contexte.SaveChanges();
foreach (var item in contexte.Flights.ToList())
{
    Console.WriteLine("Departure:  "+item.Departure+"\nDestination: "+item.Destination+"\nPlane Capacity: "+item.MyPlane.Capacity);
} 

