using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.Models
{
    public class Report
    {
        public string ReportName { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFilePath { get; set; }
        public DateTime SubmittedAt { get; set; }
        public Report(string reportName, string location, string category, string description, string attachedFilePath)
        {
            ReportName = reportName;
            Location = location;
            Category = category;
            Description = description;
            AttachedFilePath = attachedFilePath;
            SubmittedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{ReportName},{Location},{Category},{Description},{AttachedFilePath},{SubmittedAt}";
        }
    }
}
