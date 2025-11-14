using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class CategorySet
    {
        private HashSet<string> categories = new HashSet<string>();

        public void Add(string category) => categories.Add(category);

        public List<string> GetUnique() => new List<string>(categories);
    }
}
