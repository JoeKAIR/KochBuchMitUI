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
        public void GerichtHinzufügen(string name)
        {
            Gerichte neuesGericht = new(name);
            GerichteList.Add(neuesGericht);

        }
        public BindingList<Gerichte> GerichtAnzeigen()

        {

            return GerichteList;
        }
        public void ZutatzuGerichtHinzufügen(Gerichte gericht, string name, string menge, int kalorien)
        {

            gericht.ZutatenHinzufügen(name, menge, kalorien);
        }
        public bool Speichern()
        {
            var GerichteSpeichernJson = JsonSerializer.Serialize(GerichteList);
            File.WriteAllText("kochbuch.json", GerichteSpeichernJson);
            return true;
        }
        public bool DatenLaden()
        {
            if (File.Exists("kochbuch.json"))
            {
                var GerichteLadenJson = File.ReadAllText("kochbuch.json");
                var geladen=JsonSerializer.Deserialize<BindingList<Gerichte>>(GerichteLadenJson);
                if (geladen != null)
                {
                    GerichteList = geladen;
                    return true;
                }
                else GerichteList = new();
                return true;
            }
            
           
           
            return true;
        }
    }
}
