using System;


namespace KochBuchMitUI
{
    internal class Zutaten
    {
        public string Name { get; set; }
        public string Menge { get; set; }

        public int Kalorienpromenge { get; set; }
        public Zutaten(string name, string menge, int kalorienpromenge)
        {
            this.Name = name;
            this.Menge = menge;
            this.Kalorienpromenge = kalorienpromenge;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }

}
