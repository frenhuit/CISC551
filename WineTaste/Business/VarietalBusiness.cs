using WineTaste.Models;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Business
{
    public class VarietalBusiness
    {
        private readonly IVarietalRepository _varietalRepository;

        public VarietalBusiness(IVarietalRepository varietalRepository)
        {
            _varietalRepository = varietalRepository;
        }
        
        public VarietalWithWineList GetVarietalWithWineListById(int id)
        {
            var varietal = _varietalRepository.GetVarietalById(id);
            var wineList = _varietalRepository.GetWinesOfVarietal(id);
            var singleVarietalWithWineList = new VarietalWithWineList
            {
                Varietal = varietal,
                WineList = wineList
            };
            return singleVarietalWithWineList;
        }
    }
}