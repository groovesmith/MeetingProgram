using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingProgram.Models.PersonModel.Interfaces;
using System.ComponentModel.DataAnnotations;
using MeetingProgram.Models.MeetingModel;

namespace MeetingProgram.Models.PersonModel
{

    public class User : Person, IUser
    {
        public User(int personID, string firstname, string lastname, string email, int phoneNr, string userName, string passWord) : base(personID, firstname, lastname, email, phoneNr)
        {
            
            PersonID = personID;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNr = phoneNr;
            UserName = userName;
            PassWord = passWord;
        }

        public string UserName { get; set; }
        public string PassWord { get; set; } // krypter det hvis der er tid til det

        // picture file
        // personal settings 
        
        public void AddCustomer(Customer customer)
        {
           
            throw new NotImplementedException();
        }

        public void AddMeeting(Meeting meeting)
        {
            throw new NotImplementedException();
        }


        public void AddProject(ProjectModel.Project project)
        {
            throw new NotImplementedException();
        }

        public void AddSubContractor(SubContractor subContractor)
        {
            throw new NotImplementedException();
        }
        
    }
}
