using System;

namespace LaboratoireData.Models
{
    public interface IEchantillon
    {
        string Couleur { get; set; }
        DateTime DatePrelevement { get; set; }
        int Id { get; set; }
    }
}