using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> FlightList { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
        }
         public bool CheckProfile1(string firstname,string lastname)
        {
            return FirstName==firstname && LastName==lastname;
        }
        public bool CheckProfile2(string firstname, string lastname,string emailadress)
        {
            return FirstName == firstname && LastName == lastname && EmailAddress==emailadress;
        }
        public bool CheckProfile(string firstname, string lastname, string emailadress = null)
        {
            if (emailadress != null)
                return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;
            else
                return FirstName == firstname && LastName == lastname;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");

        }
    }
}
