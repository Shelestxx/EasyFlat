using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
        public class Message : IEntity
    {
            public int ID { get; }
            public int SenderID { get; }
            public int ReceiverID { get; }
            public string Text { get; }
            public DateTime SentDate { get; }

            public Message(int id, int senderID, int receiverID, string text, DateTime sentDate)
            {
                ID = id;
                SenderID = senderID;
                ReceiverID = receiverID;
                Text = text;
                SentDate = sentDate;
            }

        }
    public class MassageRepository : Repository<Message> { } 
}
