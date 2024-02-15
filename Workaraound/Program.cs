using Business.Adapters.Concrete;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Globalization;

namespace Workaraound
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Engin";
            person.LastName = "Demiroğ";
            person.DateOfBirthYear = 1985;
            person.NationalIdentity = 12345678910;
            
            PttManager pttManager = new PttManager(new PersonManager(new MernisServiceAdapter()));
            pttManager.GiveMask(person);

        }

    }
}