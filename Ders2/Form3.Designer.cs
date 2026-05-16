namespace Ders2
{
    partial class Form3
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
            buttonHesapla = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1sayi = new TextBox();
            textBox2sayi = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(122, 254);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(214, 94);
            buttonHesapla.TabIndex = 0;
            buttonHesapla.Text = "Hesapla";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "1. Sayi = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 194);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "2. Sayi =  ";
            // 
            // textBox1sayi
            // 
            textBox1sayi.Location = new Point(186, 113);
            textBox1sayi.Name = "textBox1sayi";
            textBox1sayi.Size = new Size(150, 31);
            textBox1sayi.TabIndex = 3;
            // 
            // textBox2sayi
            // 
            textBox2sayi.Location = new Point(186, 188);
            textBox2sayi.Name = "textBox2sayi";
            textBox2sayi.Size = new Size(150, 31);
            textBox2sayi.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(391, 113);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 254);
            listBox1.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 490);
            Controls.Add(listBox1);
            Controls.Add(textBox2sayi);
            Controls.Add(textBox1sayi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonHesapla);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHesapla;
        private Label label1;
        private Label label2;
        private TextBox textBox1sayi;
        private TextBox textBox2sayi;
        private ListBox listBox1;
    }
}