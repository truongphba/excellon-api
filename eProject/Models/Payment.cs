using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double TotalCost { get; set; }
        public int ClientId { get; set; }
        public string EmployeeId { get; set; }
        public PaymentStatus Status { get; set; }
        [JsonIgnore]
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [JsonIgnore]
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public ICollection<PaymentDetail> PaymentDetails { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum PaymentStatus
    {
        Cancel, Done, Pending 
    }
}