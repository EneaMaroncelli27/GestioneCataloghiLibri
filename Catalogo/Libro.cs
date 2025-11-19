using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class Libro : Prodotto
    {

        public Libro(string codiceProdotto, string titolo, decimal prezzoBase) : base(codiceProdotto, titolo, prezzoBase) 
        {
        
        }
    }
}
