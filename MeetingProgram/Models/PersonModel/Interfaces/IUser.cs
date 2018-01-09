using MeetingProgram.Models.PersonModel;
using MeetingProgram.Models.ProjectModel;
using MeetingProgram.Models.MeetingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MeetingProgram.Models.PersonModel.Interfaces
{
    public interface IUser
    {
        void AddSubContractor(SubContractor subContractor);
        void AddCustomer(Customer customer);
        void AddProject(Project project);
        void AddMeeting(Meeting meeting);     

    }
}
