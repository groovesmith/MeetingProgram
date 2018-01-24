using MeetingProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Models.ProjectModel;
using MeetingProgram.Models.PersonModel.Interfaces;

namespace MeetingProgram.Models.PersonModel
{
    public class Admin : User, IAdmin
    {
        private Admin()
        {
            
        }
        public Admin(int personID, string firstname, string lastname, string email, int phoneNr, string userName, string passWord) : base(personID, firstname, lastname, email, phoneNr, userName, passWord)
        {
            PersonID = personID;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNr = phoneNr;
            UserName = userName;
            PassWord = passWord;
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DemoteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void PromoteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
