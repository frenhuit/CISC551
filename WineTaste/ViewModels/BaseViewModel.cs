using System.Collections.Generic;
using WineTaste.Entities;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.ViewModels
{
    public class BaseViewModel
    {
        public List<CategoryWithVarietalList> AllCategoriesWithVarietalsList { get; set; }
    }
}