using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.ViewModels.ViewObjects
{
    public class VarietalWithWineList
    {
        public Varietal Varietal { get; set; }
        public List<Wine> WineList { get; set; }
    }
}