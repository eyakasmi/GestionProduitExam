using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Biologique : Produit 
    {
        public String Composition { get; set; }
    
    
        /* public override char TypeProduit()
        {
            base.TypeProduit();
            return 'B';
        }*/
    }
}
