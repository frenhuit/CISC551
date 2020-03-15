using WineTaste.Entities;
using WineTaste.Models;

namespace WineTaste.Business
{
    public class WineBusiness
    {
        private readonly IWineRepository _wineRepository;

        public WineBusiness(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public Wine GetWineById(int id)
        {
            return _wineRepository.GetWineById(id);
        }
    }
}