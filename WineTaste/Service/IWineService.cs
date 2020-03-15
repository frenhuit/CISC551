using WineTaste.Entities;

namespace WineTaste.Service
{
    public interface IWineService
    {
        Wine GetWineById(int id);
    }
}