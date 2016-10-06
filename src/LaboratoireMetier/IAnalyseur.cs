using LaboratoireData.Models;

namespace LaboratoireMetier
{
    /// <summary>
    /// Gère l'analyse d'un échantillon.
    /// </summary>
    public interface IAnalyseur
    {
        IAnalyse Demarrer(IEchantillon  echantillon);
    }
}