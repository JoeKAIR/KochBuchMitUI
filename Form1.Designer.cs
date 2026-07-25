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
            ZListe = new ListBox();
            textBox2 = new TextBox();
            ZutatenGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Überschriftgerichte
            // 
            Überschriftgerichte.AutoSize = true;
            Überschriftgerichte.Location = new Point(560, 37);
            Überschriftgerichte.Name = "Überschriftgerichte";
            Überschriftgerichte.Size = new Size(67, 20);
            Überschriftgerichte.TabIndex = 1;
            Überschriftgerichte.Text = "Gerichte:";
            // 
            // Listegerichte
            // 
            Listegerichte.FormattingEnabled = true;
            Listegerichte.Location = new Point(560, 72);
            Listegerichte.Name = "Listegerichte";
            Listegerichte.Size = new Size(179, 124);
            Listegerichte.TabIndex = 2;
            Listegerichte.SelectedIndexChanged += Listegerichte_SelectedIndexChanged;
            // 
            // ZListe
            // 
            ZListe.FormattingEnabled = true;
            ZListe.Location = new Point(560, 220);
            ZListe.Name = "ZListe";
            ZListe.Size = new Size(179, 184);
            ZListe.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 4;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // ZutatenGrid
            // 
            ZutatenGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZutatenGrid.Location = new Point(236, 253);
            ZutatenGrid.Name = "ZutatenGrid";
            ZutatenGrid.RowHeadersWidth = 51;
            ZutatenGrid.Size = new Size(300, 188);
            ZutatenGrid.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ZutatenGrid);
            Controls.Add(textBox2);
            Controls.Add(ZListe);
            Controls.Add(Listegerichte);
            Controls.Add(Überschriftgerichte);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ZutatenGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Überschriftgerichte;
        private ListBox Listegerichte;
        private ListBox ZListe;
        private TextBox textBox2;
        private DataGridView ZutatenGrid;
    }
}
