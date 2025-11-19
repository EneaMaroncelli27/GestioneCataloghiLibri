using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class Libro : Prodotto
    {
        public int Pagine { get; set; }
        private bool _IsCopertinaRigida;

        public Libro(string codiceProdotto, string titolo, decimal prezzoBase,int pagine,bool rigida) : base(codiceProdotto, titolo, prezzoBase) 
        {
            this.Pagine = pagine;
            this._IsCopertinaRigida = rigida;
        }
        public override decimal CalcolaPrezzoFinale()
        {
            if (_IsCopertinaRigida)
            {
                decimal sovrapprezzo = 2.5m;
                return sovrapprezzo + base.CalcolaPrezzoFinale();
            }
            else
            {
                return base.CalcolaPrezzoFinale();
            }

        }
        public override string OttieniDettagli()
        {
            return base.OttieniDettagli() + $"Numero pagine: {this.Pagine}, Copertina {(this._IsCopertinaRigida ? "rigida" : "non rigida") }";
        }
        public override string FormatoPerFile()
        {
            return base.FormatoPerFile() + ";" + this.Pagine + ";" + this._IsCopertinaRigida;
        }
        public bool GetRigida()
        {
            return _IsCopertinaRigida;
        }
    }
}
