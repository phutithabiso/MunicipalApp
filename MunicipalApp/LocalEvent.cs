using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp
{
    public class LocalEvent
    {
        // Properties of the LocalEvent class
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public LocalEvent(string name, DateTime date, string category, string description)
        {
            Name = name;
            EventDate = date;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"{EventDate.ToShortDateString()} - {Name} ({Category})";
        }
    }
}