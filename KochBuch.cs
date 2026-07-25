using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.ComponentModel;

namespace KochBuchMitUI
{
    internal class KochBuch
    {
        public BindingList<Gerichte> GerichteList = new();
        public BindingList<Zutaten> AlleZutaten = new();
        public ZutatenBibliothek Bibliothek { get; set; } = new();
        public void GerichtHinzufügen(string name)
        {
            Gerichte neuesGericht = new(name);
            GerichteList.Add(neuesGericht);

        }
        public BindingList<Gerichte> GerichtAnzeigen()

        {

            return GerichteList;
        }
        public List<string> BibliothekAnzeigen()
        {
            return Bibliothek.AlleÜbergeben();
        }
        
      
        public void ZutatzuGerichtHinzufügen(Gerichte gericht, string name, string menge, int kalorien)
        {
            //fügt Zutat dem Gericht was ausgewählt ist hinzu
            var dieseZutat=gericht.ZutatenHinzufügen(name, menge, kalorien);
            //speichert gleichzeitig die Zutat in der Bibliothek
            Bibliothek.ElementHinzufügen(dieseZutat.Name);
        }
        public bool Speichern()
        {
            var GerichteSpeichernJson = JsonSerializer.Serialize(GerichteList);
            var BibliothekSpeichern = JsonSerializer.Serialize(Bibliothek.AlleÜbergeben());
            File.WriteAllText("kochbuch.json", GerichteSpeichernJson);
            File.WriteAllText("Bibliothek.json", BibliothekSpeichern);
            return true;
        }
        public void DatenLaden()
        {
            if (File.Exists("kochbuch.json"))
            {
                var GerichteLadenJson = File.ReadAllText("kochbuch.json");
                var geladen=JsonSerializer.Deserialize<BindingList<Gerichte>>(GerichteLadenJson);
                if (geladen != null)
                {
                    GerichteList = geladen;
                    
                }
                else GerichteList = new();

               
                
            }

            if (File.Exists("Bibliothek.json"))
            {
                var BibliothekLaden = File.ReadAllText("Bibliothek.json");
                var Bibliothekgeladen = JsonSerializer.Deserialize<List<string>>(BibliothekLaden);
                if (Bibliothekgeladen != null)
                {
                    foreach (var b in Bibliothekgeladen)
                    {
                        Bibliothek.ElementHinzufügen(b);
                    }
                    Console.WriteLine("geladen");
                    
                }
            }

           
        }
    }
}
