using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Fournisseur
    {
        [Key]
        public int Identifiant { get; set; }

        public string ConfirmPassword { get; set; }

        [StringLength(12, MinimumLength = 3)]
        public string Nom { get; set; }

        public string Email { get; set; }

        public bool IsApproved { get; set; }

        public virtual IList<Produit> Produits { get; set; }
    }
}
