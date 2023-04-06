using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Models
{
    /// <summary>
    /// Represents an application installed on a facility for which customers can raise issues.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// The unique identifier for the application.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the facility where the application is installed.
        /// </summary>
        public int FacilityId { get; set; }

        /// <summary>
        /// The facility where the application is installed.
        /// </summary>
        public Facility Facility { get; set; }

        /// <summary>
        /// The collection of tickets raised for the application.
        /// </summary>
        public ICollection<Ticket> Tickets { get; set; }
    }
}
