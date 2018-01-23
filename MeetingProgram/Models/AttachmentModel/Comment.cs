using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.AttachmentModel
{
    public class Comment : Attachment
    {
        public Comment(int attachmentID, User attacher, DateTime timestamp, string text) : base( attachmentID, attacher, timestamp)
        {
            AttachmentID = attachmentID;
            Attacher = attacher;
            Timestamp = timestamp;
            Text = text;
        }

    public string Text { get; set; }

    }
}
