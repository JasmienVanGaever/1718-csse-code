using System;

namespace week7
{
    public class student: Person
    {
        private string studentennummer;
        private string email;
        private string login;
        private string password;

        public student(string werkEmail, string priveEmail, string achternaam, string voornaam){
            //this.email = werkEmail;
            //base.email = priveEmail;
            //base.voornaam = voornaam;
            //base.achternaam = achternaam;
        }
        
        public student(string achternaam, string voornaam) : base(achternaam, voornaam) {
            base.Achternaam = achternaam;
            base.Voornaam = voornaam;
        }
        
        }
    }
}