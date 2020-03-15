using WineTaste.Entities;
using WineTaste.Models;
using WineTaste.Service;

namespace WineTaste.Business
{
    public class WineBusiness : IWineService
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