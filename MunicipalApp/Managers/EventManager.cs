using System;
using System.Collections.Generic;
using MunicipalApp.Models;
namespace MunicipalApp.Managers
{
    public class EventManager
    {
        // Dictionary to hold events categorized by date
        public SortedDictionary<DateTime, List<LocalEvent>> EventsByDate { get; private set; }
        // Set to hold unique categories
        public HashSet<string> Categories { get; private set; }

        public EventManager()
        {
            EventsByDate = new SortedDictionary<DateTime, List<LocalEvent>>();
            Categories = new HashSet<string>();
        }
        // Method to add events to the manager
        public void AddEvent(LocalEvent ev)
        {
            
            Categories.Add(ev.Category);

            if (!EventsByDate.ContainsKey(ev.EventDate.Date))
                EventsByDate[ev.EventDate.Date] = new List<LocalEvent>();

            EventsByDate[ev.EventDate.Date].Add(ev);
        }

        // This is the important part! Make sure this method exists
        public List<LocalEvent> Search(string category, DateTime date)
        {
            List<LocalEvent> result = new List<LocalEvent>();

            foreach (var kvp in EventsByDate)
            {
                foreach (var ev in kvp.Value)
                {
                    bool categoryMatch = category == "All" || ev.Category == category;
                    bool dateMatch = ev.EventDate.Date == date;

                    if (categoryMatch && dateMatch)
                        result.Add(ev);
                }
            }

            return result;
        }
    }
}
