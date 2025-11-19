using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    internal class Prodotto
    {
        private string _codiceProdotto;
        public string Titolo { get; set; }
        public decimal PrezzoBase { get; private set; }

        protected Prodotto(string codiceProdotto, string titolo, decimal prezzoBase)
        {
            _codiceProdotto = codiceProdotto;
            Titolo = titolo;
            PrezzoBase = prezzoBase;
        }
        public string GetCodice()
        {
            return _codiceProdotto;
        }
        public virtual decimal CalcolaPrezzoFinale()
        {
            return PrezzoBase;
        }
        public virtual string OttieniDettagli()
        {
            return $"Codice Prodotto: {_codiceProdotto}, Titolo: {Titolo}, Prezzo Base: {PrezzoBase:C}";
        }
        public virtual string FormatoPerFile()
        {
            return "" + _codiceProdotto + ";" + Titolo + ";" + PrezzoBase;
        }
    }
}