namespace Ders2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEkle = new Button();
            buttonSil = new Button();
            buttonSirala = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(22, 149);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(300, 92);
            buttonEkle.TabIndex = 0;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(22, 264);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(300, 92);
            buttonSil.TabIndex = 1;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonSirala
            // 
            buttonSirala.Location = new Point(22, 375);
            buttonSirala.Name = "buttonSirala";
            buttonSirala.Size = new Size(300, 92);
            buttonSirala.TabIndex = 2;
            buttonSirala.Text = "Sırala";
            buttonSirala.UseVisualStyleBackColor = true;
            buttonSirala.Click += buttonSirala_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 89);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 3;
            label1.Text = "Sayi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 442);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 4;
            label2.Text = "En Büyük Sayi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 395);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 5;
            label3.Text = "En Kücük Sayi  :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(390, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 254);
            listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 31);
            textBox1.TabIndex = 7;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 564);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSirala);
            Controls.Add(buttonSil);
            Controls.Add(buttonEkle);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEkle;
        private Button buttonSil;
        private Button buttonSirala;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}