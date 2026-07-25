using System;
using System.Collections.Generic;
using System.Text;

namespace KochBuchMitUI
{
    internal class Gerichte
    {
        public string Name { get; set; }
        public int Kalorien {  get; set; }

        public int Schwierigkeit { get; set; }
        
        public List<Zutaten>Zutaten { get; set; } =new List<Zutaten>();

        public Gerichte(string name)
        {
            this.Name = name;
            this.Kalorien = 0;
            this.Schwierigkeit = 3;
           

            
        }
        public void ZutatenHinzufügen(string name,string menge,int kalorien)
        {
            Zutaten neueZutat = new( name, menge, kalorien);
            Zutaten.Add(neueZutat);
        }
        public override string ToString()
        {
            return $"{this.Name} ";
        }
    }
}
