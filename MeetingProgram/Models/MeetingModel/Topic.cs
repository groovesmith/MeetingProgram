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
           // SupTopics = new List<SupTopic>();
        }




        // singel topic and mulit topics 
        public Topic(string subject)
        {
            Subject = subject;
           // SupTopics = new List<SupTopic>();

        }
    
        public int TopicID { get; set; }
        public string Subject { get; set; }
        public string Index { get; set; }
       // public List<SupTopic> SupTopics { get; set; }

        //public void AddSubTopictoSubject(Topic topic)
        //{
        //    SupTopics.Add(topic);
        //}

        //public void RemoveSubTopictoSubject(Topic topic)
        //{
        //    SupTopics.Remove(topic);
           
        //}


    }

    


}
