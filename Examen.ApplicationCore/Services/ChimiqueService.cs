using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ChimiqueService : Service<Chimique>, IChimiqueService
    {

        public List<Chimique> Chimiques = new List<Chimique>();

        public ChimiqueService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        //implémentation des méthodes

        public List<Chimique> GetChimiquesPrixSuperieur(double prix)
        {
            return Chimiques.Where(c => c.Price > prix)
                .Take(5)
                .ToList();
        }
    }
}
