using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents a user that can create and work on tickets.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The unique identifier for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the role that the user belongs to.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// The role that the user belongs to.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// The collection of tickets created by the user.
        /// </summary>
        public ICollection<Ticket> CreatedTickets { get; set; }

        /// <summary>
        /// The collection of tickets assigned to the user.
        ///

        public ICollection<Ticket> AssignedTickets { get; set; }

        /// <summary>
        /// The collection of conversations the user has participated in.
        /// </summary>
        public ICollection<Conversation> Conversations { get; set; }
    }
}
