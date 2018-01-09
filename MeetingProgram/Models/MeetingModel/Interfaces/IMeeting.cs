using MeetingProgram.Models.Attachment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.MeetingModel.Interfaces
{
    interface IMeeting
    {
        void AddTopictoAgenda(string topic);
        void RemoveTopictoAgenda(Topic topic);
        void AddAtendee(PersonModel.Person atendee);
        void RemoveAtendee(PersonModel.Person atendee);
        void ChangeAtendeeRole();
        SoundFile RecordSound();
        

    }
}
