using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents a ticket that has been raised for an issue.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The title of the ticket.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the ticket.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the facility where the ticket was raised.
        /// </summary>
        public int FacilityId { get; set; }

        /// <summary>
        /// The facility where the ticket was raised.
        /// </summary>
        public Facility Facility { get; set; }

        /// <summary>
        /// The unique identifier of the application the ticket is related to.
        /// </summary>
        public int? ApplicationId { get; set; }

        /// <summary>
        /// The application the ticket is related to.
        /// </summary>
        public Application Application { get; set; }

        /// <summary>
        /// The unique identifier of the user that created the ticket.
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// The user that created the ticket.
        /// </summary>
        public User CreatedByUser { get; set; }

        /// <summary>
        /// The unique identifier of the user that the ticket is assigned to.
        /// </summary>
        public int? AssignedToUserId { get; set; }

        /// <summary>
        /// The user that the ticket is assigned to.
        /// </summary>
        public User AssignedToUser { get; set; }

        /// <summary>
        /// The unique identifier of the status of the ticket.
        /// </summary>
        public int TicketStatusId { get; set; }

        /// <summary>
        /// The status of the ticket.
        /// </summary>
        public TicketStatus TicketStatus { get; set; }

        /// <summary>
        /// The collection of conversations related to the ticket.
        /// </summary>
        public ICollection<Conversation> Conversations { get; set; }
    }
}
