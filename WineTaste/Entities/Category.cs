using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineTaste.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
    }
}
