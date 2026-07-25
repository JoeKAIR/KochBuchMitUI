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
            Zutaten = new ListBox();
            textBox2 = new TextBox();
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
            Überschriftgerichte.Click += label1_Click;
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
            // Zutaten
            // 
            Zutaten.FormattingEnabled = true;
            Zutaten.Location = new Point(560, 220);
            Zutaten.Name = "Zutaten";
            Zutaten.Size = new Size(179, 184);
            Zutaten.TabIndex = 3;
            Zutaten.SelectedIndexChanged += Zutaten_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(Zutaten);
            Controls.Add(Listegerichte);
            Controls.Add(Überschriftgerichte);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Überschriftgerichte;
        private ListBox Listegerichte;
        private ListBox Zutaten;
        private TextBox textBox2;
    }
}
