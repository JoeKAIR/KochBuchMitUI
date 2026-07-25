namespace KochBuchMitUI
{
    public partial class Form1 : Form
    {
        KochBuch kochBuch = new();
        private Gerichte? ausgewähltesGericht;
        public Form1()
        {
            InitializeComponent();
            ListBoxFüllen();
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextzuTextBox();
            }
        }
        void TextzuTextBox()
        {
            kochBuch.GerichtHinzufügen(textBox1.Text);
            textBox1.Clear();
            ListBoxFüllen();

        }
        void ListBoxFüllen()
        {
           
            Listegerichte.DataSource = kochBuch.GerichtAnzeigen();
            
        }
        void ZutatenListeFüllen(Gerichte auswahlgericht)
        {
           
            Zutaten.DataSource = auswahlgericht.Zutaten;
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Listegerichte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listegerichte.SelectedItem != null)
            {
                ausgewähltesGericht = (Gerichte)Listegerichte.SelectedItem;
                ZutatenListeFüllen(ausgewähltesGericht);
            }
        }

        private void Zutaten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ausgewähltesGericht != null) 
                
                {
                    kochBuch.ZutatzuGerichtHinzufügen(ausgewähltesGericht, textBox2.Text, "", 0);
                    textBox2.Clear();
                }
               
                
                
            }      
        }
    }
}
