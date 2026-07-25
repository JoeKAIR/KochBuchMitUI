using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KochBuchMitUI
{
    internal class ZutatenBibliothek
    {
       private HashSet<string> ZutatenAlle = new();


        public List<string> AlleÜbergeben()
        {
            return ZutatenAlle.ToList();
        }
        public void ElementHinzufügen(string zutat)
        {
            ZutatenAlle.Add(zutat);
           
        }

        public string BibliothekDurchsuchen(string suche)
        {
            ZutatenAlle.Contains(suche);
            return suche;
        }
    }
}
