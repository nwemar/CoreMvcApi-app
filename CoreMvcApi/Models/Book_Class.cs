using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcApi.Models
{
    public class Book_Class
    {
        public int id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Price { get; set; }
        public string Description { get; set; }
    }
}
