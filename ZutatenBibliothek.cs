using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
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

        public List <string> BibliothekDurchsuchen(string suche)
        {
            //List<string> SuchausgabeListe;
            var gesucht = ZutatenAlle
            .Where(x => x.Contains( suche,StringComparison.OrdinalIgnoreCase))
            .ToList();

            return gesucht;
        }
        
    }
}
