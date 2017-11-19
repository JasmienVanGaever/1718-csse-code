using System;

namespace week7
{
    public class Person{
        string voornaam;
        string achternaam;
        int leeftijd;
        string geslacht;
        string telefoonnummer;
        string email;
        string gsm;


        public string Voornaam { get => voornaam; set => voornaam = value; }
        public string Achternaam { get => achternaam; set => achternaam = value; }
        public string Email { get => email; set => email = value; }

        public Person(){

        }

        public Person(string voornaam, string achternaam){
                this.Voornaam = voornaam;
                this.achternaam = achternaam;
            }

  
   
    }
}