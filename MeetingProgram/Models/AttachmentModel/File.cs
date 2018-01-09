using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.Attachment
{
    public class File : Attachment
    {
        public File(int attachmentID, User attacher, DateTime timestamp, string fileName, string fileDesciption) : base(attachmentID, attacher, timestamp)
        {
            AttachmentID = attachmentID;
            Attacher = attacher;
            Timestamp = timestamp;
            FileName = fileName;
            FileDesciption = fileDesciption;
        }
        
        public string FileName { get; set; }
        public string FileDesciption { get; set; }


        public void UploadFile (Attachment attachment)
        {
            throw new NotImplementedException();
        }
    }
}
