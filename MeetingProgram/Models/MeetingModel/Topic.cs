﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingProgram.Models.MeetingModel;

namespace MeetingProgram.Models.MeetingModel
{
    public class Topic
    {
        // singel topic and mulit topics 
        public Topic(string subject)
        {
            Subject = subject;

        }
        public Topic(string subject, List<Topic> supTopics) 
        {
            Subject = subject;
            SupTopics = supTopics;
        }
    

        public string Subject { get; set; }
        public List<Topic> SupTopics = new List<Topic>();

        public void AddSubTopictoSubject(Topic topic)
        {
            SupTopics.Add(topic);
        }

        public void RemoveSubTopictoSubject(Topic topic)
        {
            //SupTopics.Remove(topic);
            throw new NotImplementedException();
        }


    }
}
