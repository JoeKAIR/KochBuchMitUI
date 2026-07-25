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
        private BindingList<Gerichte> GerichteList = new();
        private BindingList<Zutaten> AlleZutaten = new();
        private ZutatenBibliothek Bibliothek { get; set; } = new();
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
                try
                {
                    var GerichteLadenJson = File.ReadAllText("kochbuch.json");
                    var geladen = JsonSerializer.Deserialize<BindingList<Gerichte>>(GerichteLadenJson);
                    if (geladen != null)
                    {
                        GerichteList = geladen;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Laden fehlgeschlagen"+ex);
                }


            }
            else GerichteList = new();
            

            if (File.Exists("Bibliothek.json"))
            {
                try
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
                catch(Exception ex)
                {
                    MessageBox.Show("Laden Fehlgeschlagen"+ex);
                }
               
            }

           
        }
    }
}
