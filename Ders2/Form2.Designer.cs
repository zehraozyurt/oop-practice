namespace Ders2
{
    partial class Form2
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
            buttonBolgeyiBul = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxYEkseni = new TextBox();
            textBoxXEkseni = new TextBox();
            labelSonuc = new Label();
            SuspendLayout();
            // 
            // buttonBolgeyiBul
            // 
            buttonBolgeyiBul.Location = new Point(148, 205);
            buttonBolgeyiBul.Name = "buttonBolgeyiBul";
            buttonBolgeyiBul.Size = new Size(209, 90);
            buttonBolgeyiBul.TabIndex = 0;
            buttonBolgeyiBul.Text = "Bölgeyi Bul";
            buttonBolgeyiBul.UseVisualStyleBackColor = true;
            buttonBolgeyiBul.Click += buttonBolgeyiBul_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 48);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "X Ekseni :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 121);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Y Ekseni : ";
            // 
            // textBoxYEkseni
            // 
            textBoxYEkseni.Location = new Point(192, 121);
            textBoxYEkseni.Name = "textBoxYEkseni";
            textBoxYEkseni.Size = new Size(165, 31);
            textBoxYEkseni.TabIndex = 3;
            // 
            // textBoxXEkseni
            // 
            textBoxXEkseni.Location = new Point(192, 48);
            textBoxXEkseni.Name = "textBoxXEkseni";
            textBoxXEkseni.Size = new Size(165, 31);
            textBoxXEkseni.TabIndex = 4;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(83, 339);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(75, 25);
            labelSonuc.TabIndex = 5;
            labelSonuc.Text = "Sonuc : ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 431);
            Controls.Add(labelSonuc);
            Controls.Add(textBoxXEkseni);
            Controls.Add(textBoxYEkseni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBolgeyiBul);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBolgeyiBul;
        private Label label1;
        private Label label2;
        private TextBox textBoxYEkseni;
        private TextBox textBoxXEkseni;
        private Label labelSonuc;
    }
}