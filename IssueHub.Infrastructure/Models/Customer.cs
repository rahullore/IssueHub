using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents a customer that can raise issues.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The unique identifier for the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The collection of facilities owned by the customer.
        /// </summary>
        public ICollection<Facility> Facilities { get; set; }
    }
}
