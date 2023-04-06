using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents a facility where customers can raise issues.
    /// </summary>
    public class Facility
    {
        /// <summary>
        /// The unique identifier for the facility.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the facility.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the customer that owns the facility.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The customer that owns the facility.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// The collection of tickets raised for the facility.
        /// </summary>
        public ICollection<Ticket> Tickets { get; set; }

        /// <summary>
        /// The collection of applications installed on the facility.
        /// </summary>
        public ICollection<Application> Applications { get; set; }
    }

}
