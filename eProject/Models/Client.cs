using Newtonsoft.Json;
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
        //mã số thuế
        public string TaxCode { get; set; }
        //mã khách hàng
        public string ClientCode { get; set; }
        //Nguồn khách hàng
        public string ClientSource { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        //ngành nghề 
        public string Career { get; set; }
        public string Email { get; set; }
        // Người liên hệ chính
        public string PointOfContact { get; set; }
        // chức vụ
        public string Position { get; set; }
        //mô tả về khách hàng
        public string Description { get; set; }
        public ClientStatus Status { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum ClientStatus
    {
        Deactive, Active
    }
}