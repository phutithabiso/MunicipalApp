using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class RequestHashTable
    {
        private Dictionary<int, ServiceRequest> map = new Dictionary<int, ServiceRequest>();

        public void Add(ServiceRequest req) => map[req.RequestId] = req;

        public ServiceRequest Get(int id)
        {
            return map.ContainsKey(id) ? map[id] : null;
        }

        public List<ServiceRequest> GetAll() => new List<ServiceRequest>(map.Values);
    }
}
