using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp
{
    public class RequestNode
    {
        public Report Request { get; set; }
        public RequestNode Left { get; set; }
        public RequestNode Right { get; set; }

        public RequestNode(Report request) => Request = request;
    }
}
