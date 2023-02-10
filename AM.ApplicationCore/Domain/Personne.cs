using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateDeNaissance { get; set; }

       public override string ToString ()
        {
            return $"Id: {Id}, Nom: {Nom}, Prenom: {Prenom}, Email: {Email}, DateNaissance: {DateDeNaissance}";
        }

        public Personne( string nom, string prenom, string email, string password, DateTime dateDeNaissance)
        {
           
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            DateDeNaissance = dateDeNaissance;
        }
        public Personne()
        {

        }
        public bool Login(string nom, string password)
        {
            return nom==Nom && password==Password;
        }
        public bool Login(string nom, string password,string email=null)
        {
            return nom == Nom && password == Password && email==Email;
        }
        public bool Loginn(string nom, string password, string email = null)
        {
            return nom == Nom && password == Password && (email == Email ||email== null);
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("I am a Person");
        }

    }
}
