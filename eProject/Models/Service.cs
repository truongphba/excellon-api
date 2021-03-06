using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ServiceStatus Status { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [JsonIgnore]
        public virtual Department Department { get; set; }
        public ICollection<PaymentDetail> PaymentDetails { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ServiceStatus
    {
        Deactive, Active
    }

    public class AllService
    {
        public int InBoundCount { get; set; }
        public int OutBoundCount { get; set; }
        public int TeleCount { get; set; }
    }
}