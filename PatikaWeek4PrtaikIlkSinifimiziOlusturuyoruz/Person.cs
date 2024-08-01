using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PrtaikIlkSinifimiziOlusturuyoruz
{
    public class Person
    {
        //Field tanımlamaları
        private string name;
        private string surname;
        private string birthDate;
        private string role;

        //Propetry Tanımlamaları
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {

                birthDate = value;
                

            }
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        //Konsola yazdırma methodu
            public void Display()
        {
            Console.WriteLine($"{role}'nin ismi:{name} Soyismi:{surname} Doğum Tarihi:{birthDate}");
        }

        
    }
}

