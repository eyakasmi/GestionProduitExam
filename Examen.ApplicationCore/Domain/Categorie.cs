using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Produit> Produits { get; set; }
    }
}
