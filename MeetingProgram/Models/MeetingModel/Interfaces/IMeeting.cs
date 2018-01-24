using MeetingProgram.Models.AttachmentModel;
using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.MeetingModel.Interfaces
{
    interface IMeeting
    {
        void AddAtendee(Person atendee);
        void RemoveAtendee(Person atendee);
        void ChangeAtendeeRole();
        SoundFile RecordSound();
        

    }
}
