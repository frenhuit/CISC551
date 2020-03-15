using WineTaste.Models;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Service
{
    public interface IVarietalService
    {
        VarietalWithWineList GetVarietalWithWineListById(int id);
    }
}