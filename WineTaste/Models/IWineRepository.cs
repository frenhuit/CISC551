using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.Models
{
    public interface IWineRepository
    {
        List<Wine> GetWines();
        Wine GetWineById(int id);
    }
}