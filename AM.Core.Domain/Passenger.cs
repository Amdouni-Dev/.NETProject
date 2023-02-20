using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get;set; }
        public int Age; 

        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAddress:" + EmailAddress + ";"
                + "FirstName:" + FirstName + ";"
                + "LastName:" + LastName + ";"
                + "TelNumber:" + TelNumber;
        }

        //Question11.a
        public bool CheckProfile ( string lastName, string firstName)
        {
         if (lastName==LastName && firstName == FirstName) 
                return true;   
         return false;
        }

        //Question11.b
        /*
        public bool CheckProfile(string lastName, string firstName, string emailAdress)
        {
            if (lastName == LastName && firstName == FirstName && emailAdress == EmailAddress)
                return true;
            return false;
        }
        */
        //*Question11.c (on remplace les 2 fonctions des Q.11.a ET Q.11.b )
        public bool CheckProfile(string lastName, string firstName, string emailAdress=null)
        {
            if (emailAdress == null)
                return lastName == LastName && firstName == FirstName;
            else
                return lastName == LastName && firstName == FirstName && emailAdress == EmailAddress;               
        }


        //question 12 Polymorphisme par héritage
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
        //Question 13
        public void GetAge(DateTime birthDate, out int calculatedAge)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            calculatedAge = age;
        }

        // Autres propriétés et méthodes de la classe Passenger
        public void GetAge1(Passenger aPassenger)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - aPassenger.BirthDate.Year;

            if (now < BirthDate.AddYears(age))
            {
                age--;
            }

            aPassenger.Age = age;
        }

        public void GetAge2(DateTime birthDate, ref int calculatedAge)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            calculatedAge = age;
        }
    }

}
