using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingProgram.Models.MeetingModel;

namespace MeetingProgram.Models.MeetingModel
{
    public class Topic
    {
        public Topic()
        {

        }

        public Topic(string subject)
        {
            Subject = subject;


        }
    
        public int TopicID { get; set; }
        public string Subject { get; set; }
        public string Index { get; set; }
        // public ICollection<SupTopic> SupTopics { get; set; }


    }




}
