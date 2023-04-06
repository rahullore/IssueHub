using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public byte[] Data { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
