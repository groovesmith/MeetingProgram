using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.PersonModel.Interfaces
{
    public interface IAdmin : IUser
    {
        void AddUser(User user);
        void PromoteUser(User user);
        void DemoteAdmin(Admin admin);
        

    }
}
