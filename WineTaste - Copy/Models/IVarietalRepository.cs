using System.Collections.Generic;
using WineTaste.Entities;

namespace WineTaste.Models
{
    public interface IVarietalRepository
    {
        List<Varietal> GetVarietals();
        Varietal GetVarietalById(int id);
        List<Wine> GetWinesOfVarietal(int varietalId);
    }
}