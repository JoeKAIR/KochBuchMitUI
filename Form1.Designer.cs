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
            SuchVorschläge = new ListBox();
            ZutatenGrid = new DataGridView();
            Listegerichte = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            Überschrift = new Label();
            bearbeitenLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // SuchVorschläge
            // 
            SuchVorschläge.FormattingEnabled = true;
            SuchVorschläge.Location = new Point(19, 90);
            SuchVorschläge.Name = "SuchVorschläge";
            SuchVorschläge.Size = new Size(150, 104);
            SuchVorschläge.TabIndex = 5;
            SuchVorschläge.KeyDown += SuchVorschlägeKeyDown;
            // 
            // ZutatenGrid
            // 
            ZutatenGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ZutatenGrid.BackgroundColor = SystemColors.ControlLight;
            ZutatenGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZutatenGrid.GridColor = SystemColors.MenuBar;
            ZutatenGrid.Location = new Point(238, 106);
            ZutatenGrid.Name = "ZutatenGrid";
            ZutatenGrid.RowHeadersWidth = 51;
            ZutatenGrid.Size = new Size(491, 315);
            ZutatenGrid.TabIndex = 5;
            // 
            // Listegerichte
            // 
            Listegerichte.FormattingEnabled = true;
            Listegerichte.Location = new Point(11, 94);
            Listegerichte.Name = "Listegerichte";
            Listegerichte.Size = new Size(162, 224);
            Listegerichte.TabIndex = 2;
            Listegerichte.SelectedIndexChanged += Listegerichte_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(19, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Neue Zutat Hinzufügen";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += EingabeErfolgt;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Neues Gericht Hinzufügen";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1169, 595);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bearbeitenLabel);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(Listegerichte);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1161, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(Überschrift);
            tabPage2.Controls.Add(ZutatenGrid);
            tabPage2.Controls.Add(SuchVorschläge);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1161, 562);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(840, 220);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // Überschrift
            // 
            Überschrift.AutoSize = true;
            Überschrift.Location = new Point(420, 3);
            Überschrift.Name = "Überschrift";
            Überschrift.Size = new Size(50, 20);
            Überschrift.TabIndex = 6;
            Überschrift.Text = "label1";
            // 
            // bearbeitenLabel
            // 
            bearbeitenLabel.AutoSize = true;
            bearbeitenLabel.Location = new Point(198, 94);
            bearbeitenLabel.Name = "bearbeitenLabel";
            bearbeitenLabel.Size = new Size(81, 20);
            bearbeitenLabel.TabIndex = 3;
            bearbeitenLabel.TabStop = true;
            bearbeitenLabel.Text = "Bearbeiten";
            bearbeitenLabel.LinkClicked += bearbeitenLabel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 595);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox SuchVorschläge;
        private DataGridView ZutatenGrid;
        private ListBox Listegerichte;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label Überschrift;
        private LinkLabel bearbeitenLabel;
    }
}
