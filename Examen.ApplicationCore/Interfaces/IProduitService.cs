using Examen.ApplicationCore.Domain;
using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IProduitService : IService<Produit>
    {
        //signature des méthodes

        public IList<Fournisseur> GetFournisseurByCategorie(Categorie categorie);
    }
}
