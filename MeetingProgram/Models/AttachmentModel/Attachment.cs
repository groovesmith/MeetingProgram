using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.AttachmentModel
{
    public class Attachment
    {
        public Attachment(int attachmentID, User attacher, DateTime timestamp)
        {
            AttachmentID = attachmentID;
            Attacher = attacher;
            Timestamp = timestamp;
        }
        public int AttachmentID { get; set; }
        public User Attacher { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
