using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.ViewModels.ViewObjects
{
    public class CategoryWithVarietalList
    {
        public Category Category { get; set; }
        public List<Varietal> VarietalList { get; set; }
    }
}