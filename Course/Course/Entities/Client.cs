using System;

namespace Course.Entities
{
    class Client
    {
        public string Name { get; set; }                         //nome email e data de nascimento
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)              //construtores
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()                //Tostring
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}