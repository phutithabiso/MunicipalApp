using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.Models
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string ResidentName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // e.g., Pending, In Progress, Completed
        public DateTime DateSubmitted { get; set; }

        public ServiceRequest(int id, string name, string desc, string status)
        {
            RequestId = id;
            ResidentName = name;
            Description = desc;
            Status = status;
            DateSubmitted = DateTime.Now;
        }

        public override string ToString()
        {
           
            return $"{RequestId}: {ResidentName} - {Description} ({Status})";
        }
    }
}
