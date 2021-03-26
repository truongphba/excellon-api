using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public ProductService Status { get; set; }
        [JsonIgnore]
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public ICollection<PaymentDetail> PaymentDetails { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ProductService
    {
        Deactive, Active
    }
}