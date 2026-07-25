using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace KochBuchMitUI
{
    internal class Gerichte
    {
        public string Name { get; set; }
        public int Kalorien {  get; set; }

        public int Schwierigkeit { get; set; }
        
        public BindingList<Zutaten>Zutaten { get; set; } =new BindingList<Zutaten>();

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
