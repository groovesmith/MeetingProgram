using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.AttachmentModel
{
    public class SoundFile : File
    {
        public SoundFile(int attachmentID, User attacher, DateTime timestamp, string fileName, string fileDesciption) : base (attachmentID, attacher, timestamp, fileName, fileDesciption)
        {
            AttachmentID = attachmentID;
            Attacher = attacher;
            Timestamp = timestamp;
            FileName = fileName;
            FileDesciption = fileDesciption;
        }


        void Playsound()
        {
            throw new NotImplementedException();
        }

        void RecordSound()
        {
            throw new NotImplementedException();
        }
    }
}
