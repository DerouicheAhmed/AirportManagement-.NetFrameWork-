using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Display(Name ="Date Of Birth"),DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [MaxLength(7)]
        public int PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        [MinLength(3), MaxLength(25,ErrorMessage ="Les règles ne sont Pas respectés")]

        public FullName fullname{ get; set; }
        [MinLength(8), MaxLength(8)]
        public int TelNumber { get; set; }
        public ICollection<Flight> FlightList { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, TelNumber: {TelNumber}";
        }
        // public bool CheckProfile1(string firstname,string lastname)
        //{
        //    return FirstName==firstname && LastName==lastname;
        //}
        //public bool CheckProfile2(string firstname, string lastname,string emailadress)
        //{
        //    return FirstName == firstname && LastName == lastname && EmailAddress==emailadress;
        //}
        //public bool CheckProfile(string firstname, string lastname, string emailadress = null)
        //{
        //    if (emailadress != null)
        //        return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;
        //    else
        //        return FirstName == firstname && LastName == lastname;
        //}
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");

        }
        
    }
}
