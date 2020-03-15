using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineTaste.Entities
{
    public class Varietal
    {
        public int VarietalId { get; set; }
        public int CategoryId { get; set; }
        public string VarietalName { get; set; }
        public string VarietalDescription { get; set; }
        public string VarietalImage { get; set; }
    }
}
