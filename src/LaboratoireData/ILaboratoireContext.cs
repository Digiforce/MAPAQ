using LaboratoireData.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratoireData
{
    public interface ILaboratoireContext
    {
        DbSet<Analyse> Analyses { get; set; }
    }
}