namespace KochBuchMitUI
{
    partial class Form1
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Überschriftgerichte = new Label();
            Listegerichte = new ListBox();
            textBox2 = new TextBox();
            ZutatenGrid = new DataGridView();
            MeinKochBuchLabel = new Label();
            ZutatenVonAuswahlLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBox1 = new ListBox();
            ZListe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Neues Gericht Hinzufügen";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Überschriftgerichte
            // 
            Überschriftgerichte.AutoSize = true;
            Überschriftgerichte.Location = new Point(331, 0);
            Überschriftgerichte.Name = "Überschriftgerichte";
            Überschriftgerichte.Size = new Size(67, 20);
            Überschriftgerichte.TabIndex = 1;
            Überschriftgerichte.Text = "Gerichte:";
            // 
            // Listegerichte
            // 
            Listegerichte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Listegerichte.FormattingEnabled = true;
            Listegerichte.Location = new Point(3, 70);
            Listegerichte.Name = "Listegerichte";
            Listegerichte.Size = new Size(120, 364);
            Listegerichte.TabIndex = 2;
            Listegerichte.SelectedIndexChanged += Listegerichte_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(129, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Neue Zutat Hinzufügen";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += EingabeErfolgt;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // ZutatenGrid
            // 
            ZutatenGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ZutatenGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZutatenGrid.BackgroundColor = SystemColors.ControlLight;
            ZutatenGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZutatenGrid.GridColor = SystemColors.MenuBar;
            ZutatenGrid.Location = new Point(129, 70);
            ZutatenGrid.Name = "ZutatenGrid";
            ZutatenGrid.RowHeadersWidth = 51;
            ZutatenGrid.Size = new Size(196, 315);
            ZutatenGrid.TabIndex = 5;
            // 
            // MeinKochBuchLabel
            // 
            MeinKochBuchLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MeinKochBuchLabel.AutoSize = true;
            MeinKochBuchLabel.Location = new Point(3, 47);
            MeinKochBuchLabel.Name = "MeinKochBuchLabel";
            MeinKochBuchLabel.Size = new Size(109, 20);
            MeinKochBuchLabel.TabIndex = 6;
            MeinKochBuchLabel.Text = "Meine Gerichte";
            // 
            // ZutatenVonAuswahlLabel
            // 
            ZutatenVonAuswahlLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ZutatenVonAuswahlLabel.AutoSize = true;
            ZutatenVonAuswahlLabel.Location = new Point(129, 47);
            ZutatenVonAuswahlLabel.Name = "ZutatenVonAuswahlLabel";
            ZutatenVonAuswahlLabel.Size = new Size(125, 20);
            ZutatenVonAuswahlLabel.TabIndex = 7;
            ZutatenVonAuswahlLabel.Text = "Zutaten(Auswahl)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.75F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(Überschriftgerichte, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(MeinKochBuchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(Listegerichte, 0, 2);
            tableLayoutPanel1.Controls.Add(ZutatenVonAuswahlLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(ZutatenGrid, 1, 2);
            tableLayoutPanel1.Controls.Add(listBox1, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.222222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1111145F));
            tableLayoutPanel1.Size = new Size(495, 450);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(331, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 8;
            // 
            // ZListe
            // 
            ZListe.FormattingEnabled = true;
            ZListe.Location = new Point(541, 98);
            ZListe.Name = "ZListe";
            ZListe.Size = new Size(151, 28);
            ZListe.TabIndex = 9;
            ZListe.TextChanged += EingabeComboBox;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ZListe);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label Überschriftgerichte;
        private ListBox Listegerichte;
        private TextBox textBox2;
        private DataGridView ZutatenGrid;
        private Label MeinKochBuchLabel;
        private Label ZutatenVonAuswahlLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox1;
        private ComboBox ZListe;
    }
}
