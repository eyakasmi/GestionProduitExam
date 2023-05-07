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
    public class ProduitService : Service<Produit>, IProduitService
    {

        public List<Produit> Produits = new List<Produit>();

        public ProduitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        //implémentation des méthodes

        public IList<Fournisseur> GetFournisseurByCategorie(Categorie categorie)
        {
            return Produits
                .Where(p => p.CategorieFk == categorie.Id)
                .SelectMany(p => p.Fournisseurs)
                .Distinct()
                .ToList();
        }
    }
}
