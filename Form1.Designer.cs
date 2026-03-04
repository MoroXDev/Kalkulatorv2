namespace Kalkulatorv2
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            wzory = new ComboBox();
            button1 = new Button();
            wynik = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 39);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Bok1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 110);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Bok2";
            // 
            // wzory
            // 
            wzory.FormattingEnabled = true;
            wzory.Items.AddRange(new object[] { "Prostokąt_Obwód", "Kwadrat_Obwód", "Koło_Obwód", "Prostokąt_Pole", "Kwadrat_Pole", "Trójkąt_Pole", "Koło_Pole" });
            wzory.Location = new Point(367, 57);
            wzory.Name = "wzory";
            wzory.Size = new Size(133, 23);
            wzory.TabIndex = 4;
            wzory.Text = "Wybierz wzór";
            wzory.SelectedIndexChanged += wzory_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(367, 121);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 5;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // wynik
            // 
            wynik.AutoSize = true;
            wynik.Location = new Point(367, 175);
            wynik.Name = "wynik";
            wynik.Size = new Size(41, 15);
            wynik.TabIndex = 6;
            wynik.Text = "wynik:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 39);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Wzór";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(wynik);
            Controls.Add(button1);
            Controls.Add(wzory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox wzory;
        private Button button1;
        private Label wynik;
        private Label label3;
    }
}
