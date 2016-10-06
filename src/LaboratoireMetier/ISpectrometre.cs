using LaboratoireData.Models;

namespace LaboratoireMetier
{
    /// <summary>
    /// Analyse des échantillons en fonction de leur couleur.
    /// </summary>
    public interface ISpectrometre
    {
        /// <summary>
        /// détermine le type de cristal en fonction de la couleur de l'échantillon.
        /// </summary>
        /// <param name="echantillon"></param>
        /// <returns>Le type de cristal analysé.</returns>
        TypeCristal Analyser(IEchantillon echantillon);
    }
}