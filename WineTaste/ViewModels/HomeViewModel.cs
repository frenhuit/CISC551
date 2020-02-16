using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}