using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Chimique : Produit
    {
        public String NomLab { get; set; }
        public String Ville { get; set; }


        /*public override char TypeProduit()
        {
            base.TypeProduit();
            return 'C';
        }*/

    }
}
