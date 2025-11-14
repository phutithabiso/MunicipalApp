using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class SortedRequestDirectory
    {
        private SortedDictionary<string, List<ServiceRequest>> directory =
            new SortedDictionary<string, List<ServiceRequest>>();

        public void Add(ServiceRequest req)
        {
            if (!directory.ContainsKey(req.ResidentName))
                directory[req.ResidentName] = new List<ServiceRequest>();

            directory[req.ResidentName].Add(req);
        }

        public SortedDictionary<string, List<ServiceRequest>> GetAll()
        {
            return directory;
        }
    }
}
