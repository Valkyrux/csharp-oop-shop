using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codice;
        private string nome { get; set; }
        private string? descrizione { get; set; }
        private double prezzo;
        private int iva { get; set; }

        public string GetNomeEsteso()
        {
            return GetCodice() + this.nome;
        }

        public string GetCodice()
        {
            string sCodice =  "" + codice;
            string risultato = "";
            int numeroDiZeru = 13 - sCodice.Length;
            for (int i = 0; i < numeroDiZeru; i++)
            {
                risultato += "0";
            }
            return risultato + sCodice;
        }

        private void SetCodice()
        {
            Random aRand = new Random();
            codice = aRand.Next(0, 99999999);
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public double GetPrezzoIvato()
        {
            return prezzo + prezzo * iva / 100;
        }

        public Prodotto(string nome, double prezzo, int iva)
        {
            this.nome = nome;
            this.prezzo = prezzo;   
            this.iva = iva;
            SetCodice();
        }

        public Prodotto(string nome, double prezzo, int iva, string descrizione)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.iva = iva;
            this.descrizione = descrizione;
            SetCodice();
        }
    }
}
