using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public int ProductId { get; set; }
        public int ServiceId { get; set; }
        public int AmoutEmployee { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Cost { get; set; }
        public PaymentDetailStatus Status { get; set; }
        [JsonIgnore]
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum PaymentDetailStatus
    {
        Deactive, Active
    }
}