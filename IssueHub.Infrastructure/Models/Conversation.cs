using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }

        public User User { get; set; }
        public Ticket Ticket { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
