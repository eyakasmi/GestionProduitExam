using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Produit
    {
        [Key]
        public int ProduitId { get; set; }

        public string Nom { get; set; }

        public double Price { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = " DateProd must be a valid date")]
        public DateTime DateProd { get; set; }

        public string Destination { get; set; }

        [ForeignKey("Categorie")]
        public int CategorieFk { get; set; }

        public virtual IList<Fournisseur> Fournisseurs { get; set; }
        public char TypeProduit { get; set; }
       /* public virtual char TypeProduit()
        {
            return 'P';
        }*/
    }
}
