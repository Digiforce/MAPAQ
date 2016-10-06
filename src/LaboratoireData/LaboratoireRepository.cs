using LaboratoireData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoireData
{
    public class LaboratoireRepository : ILaboratoireRepository
    {

        private LaboratoireContext context;

        public LaboratoireRepository(LaboratoireContext context)
        {
            this.context = context;
        }

        public IEnumerable<IAnalyse> GetAnalyses()
        {
            return context.Analyses.ToList();
        }

        public IAnalyse GetAnalyseByID(int id)
        {
            return context.Analyses.SingleOrDefault(x => x.Id == id);
        }

        public void InsertAnalyse(IAnalyse analyse)
        {
            Analyse analyselocal = (Analyse) analyse;

            context.Analyses.Add(analyselocal);
        }

        public void DeleteAnalyse(int analyseID)
        {
            Analyse analyse = context.Analyses.SingleOrDefault(x => x.Id == analyseID);

            if (analyse != null)
                context.Analyses.Remove(analyse);
        }

        public void UpdateAnalyse(IAnalyse analyse)
        {
            context.Entry(analyse).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
