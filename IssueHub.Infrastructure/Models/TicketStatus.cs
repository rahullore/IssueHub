using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents the status of a ticket.
    /// </summary>
    public class TicketStatus
    {
        /// <summary>
        /// The unique identifier for the ticket status.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the ticket status.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The collection of tickets that are in the status.
        /// </summary>
        public ICollection<Ticket> Tickets { get; set; }
    }
}
