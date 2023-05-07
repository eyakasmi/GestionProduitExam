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
    public class BiologiqueService : Service<Biologique>, IBiologiqueService
    {

        public List<Biologique> Biologiques = new List<Biologique>();

        public BiologiqueService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public double GetMoyennePrixCategorie(Categorie categorie)
        {
            return Biologiques
                .Where(b => b.CategorieFk == categorie.Id)
                .Select(b => b.Price)
                .Average();
        }
    }
}
