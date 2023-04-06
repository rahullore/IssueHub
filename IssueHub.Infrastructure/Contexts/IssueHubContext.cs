using IssueHub.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueHub.Infrastructure.Contexts
{
    public class IssueHubContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Application> Applications { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Your Connection String");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Facility>()
                .HasOne(f => f.Customer)
                .WithMany(c => c.Facilities)
                .HasForeignKey(f => f.CustomerId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Facility)
                .WithMany(f => f.Tickets)
                .HasForeignKey(t => t.FacilityId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.CreatedByUser)
                .WithMany(u => u.CreatedTickets)
                .HasForeignKey(t => t.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.AssignedToUser)
                .WithMany(u => u.AssignedTickets)
                .HasForeignKey(t => t.AssignedToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.TicketStatus)
                .WithMany(ts => ts.Tickets)
                .HasForeignKey(t => t.TicketStatusId);

            modelBuilder.Entity<Conversation>()
                .HasOne(c => c.Ticket)
                .WithMany(t => t.Conversations)
                .HasForeignKey(c => c.TicketId);

            modelBuilder.Entity<Conversation>()
                .HasOne(c => c.User)
                .WithMany(u => u.Conversations)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Attachment>()
                .HasOne(a => a.Conversation)
                .WithMany(c => c.Attachments)
                .HasForeignKey(a => a.ConversationId);

            modelBuilder.Entity<Facility>()
                .HasMany(f => f.Applications)
                .WithOne(a => a.Facility)
                .HasForeignKey(a => a.FacilityId);

            modelBuilder.Entity<Application>()
                .HasMany(a => a.Tickets)
                .WithOne(t => t.Application)
                .HasForeignKey(t => t.ApplicationId);
        }

    }
}
