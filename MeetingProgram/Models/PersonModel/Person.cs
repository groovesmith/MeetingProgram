using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace MeetingProgram.Models.PersonModel
{
    public abstract class Person
    {
        protected Person() { }
        protected Person(int personID, string firstname, string lastname, string email, int phoneNr )
        {
            PersonID = personID;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNr = phoneNr;
        }

        //privat eller protected kan ikke lave en user nemt hvis den er privat spørg folk
        [Key]
        public int PersonID { get; protected set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                Regex reg = new Regex(@"^[\w.-]+@[\w.-]+\.[\w-]+$");
                // checks if the mail is valid
                if (reg.Match(value).Success)
                {
                    _email = value;
                }
                else
                {
                    throw new Exceptions.InvalidEmailException();
                }
            }
        }

        public int PhoneNr      { get; set; }

        public string FullName => $"{FirstName} {LastName}";

    }
}
