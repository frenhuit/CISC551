using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.ViewModels
{
    public class BaseViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}