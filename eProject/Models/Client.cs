using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ClientStatus Status { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Product> Products { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ClientStatus
    {
        Deactive, Active
    }
}