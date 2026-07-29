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
            SuchVorschläge.Visible = false;
            tabControl1.SelectedIndex = 0;
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
                Überschrift.Text = ausgewähltesGericht.Name;
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

                SuchVorschläge.Visible = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                SuchVorschläge.Focus();
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
            SuchVorschläge.Visible = true;
            SuchVorschläge.DataSource = kochBuch.SucheNachString(textBox2.Text);

        }

        private void ZListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EingabeComboBox(object sender, EventArgs e)
        {
            //ZListe.DataSource = kochBuch.SucheNachString(textBox2.Text);
        }

        private void SuchVorschlägeKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ausgewähltesGericht != null && SuchVorschläge.SelectedItem != null)

                {
                    kochBuch.ZutatzuGerichtHinzufügen(ausgewähltesGericht, SuchVorschläge.SelectedItem.ToString(), "", 0);
                    textBox2.Clear();
                    //ZutatenListe();
                }
                else textBox2.Focus();
                SuchVorschläge.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bearbeitenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
