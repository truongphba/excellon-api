using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public ContactStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ContactStatus
    {
        Pending, Done
    }
}