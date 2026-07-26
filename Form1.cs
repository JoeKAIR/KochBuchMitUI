namespace KochBuchMitUI
{
    public partial class Form1 : Form
    {
        KochBuch kochBuch = new();
        private Gerichte? ausgewähltesGericht;
        public Form1()
        {
            InitializeComponent();
            ZutatenListe();
            kochBuch.DatenLaden();
            Listegerichte.DataSource = kochBuch.GerichtAnzeigen();
            //ZListe.DataSource = kochBuch.BibliothekAnzeigen();
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kochBuch.GerichtHinzufügen(textBox1.Text);
                textBox1.Clear();
            }
        }


        void ZutatenListe()
        {
            //ZListe.DataSource = kochBuch.BibliothekAnzeigen();
        }
        void ZutatenListeFüllen(Gerichte auswahlgericht)
        {

            ZutatenGrid.DataSource = auswahlgericht.Zutaten;



        }



        private void Listegerichte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listegerichte.SelectedItem != null)
            {
                ausgewähltesGericht = (Gerichte)Listegerichte.SelectedItem;
                ZutatenListeFüllen(ausgewähltesGericht);
            }
        }



        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ausgewähltesGericht != null)

                {
                    kochBuch.ZutatzuGerichtHinzufügen(ausgewähltesGericht, textBox2.Text, "", 0);
                    textBox2.Clear();
                    //ZutatenListe();
                }



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            kochBuch.Speichern();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EingabeErfolgt(object sender, EventArgs e)
        {
            // kochBuch.SucheNachString(this.Text);
            //listBox1.DataSource = kochBuch.SucheNachString(textBox2.Text);
          //  ZListe.DataSource = kochBuch.SucheNachString(ZListe.Text);
        }

        private void ZListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EingabeComboBox(object sender, EventArgs e)
        {
            ZListe.DataSource = kochBuch.SucheNachString(textBox2.Text);
        }
    }
}
