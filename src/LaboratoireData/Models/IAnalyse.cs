using System;

namespace LaboratoireData.Models
{
    public interface IAnalyse
    {

        int Id { get; set; }
        DateTime DateAnalyse { get; set; }
        IEchantillon Echantillon { get; set; }
        TypeCristal Resultat { get; set; }

    }
}
