using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DepartmentStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Service> Services { get; set; }

    }

    public enum DepartmentStatus
    {
        Deactive, Active
    }
}