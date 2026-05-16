namespace Ders2
{
    partial class Form6
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
            textBox1 = new TextBox();
            listBoxSol = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSirala = new Button();
            buttonSil = new Button();
            buttonEkle = new Button();
            listBoxSag = new ListBox();
            buttonSagEkle = new Button();
            buttonSolEkle = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 31);
            textBox1.TabIndex = 15;
            // 
            // listBoxSol
            // 
            listBoxSol.FormattingEnabled = true;
            listBoxSol.Location = new Point(435, 39);
            listBoxSol.Name = "listBoxSol";
            listBoxSol.Size = new Size(298, 279);
            listBoxSol.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 380);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 13;
            label3.Text = "En Kücük Sayi  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 437);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 12;
            label2.Text = "En Büyük Sayi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 36);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 11;
            label1.Text = "Sayi :";
            // 
            // buttonSirala
            // 
            buttonSirala.Location = new Point(67, 322);
            buttonSirala.Name = "buttonSirala";
            buttonSirala.Size = new Size(300, 92);
            buttonSirala.TabIndex = 10;
            buttonSirala.Text = "Sırala";
            buttonSirala.UseVisualStyleBackColor = true;
            buttonSirala.Click += buttonSirala_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(67, 211);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(300, 92);
            buttonSil.TabIndex = 9;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(67, 96);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(300, 92);
            buttonEkle.TabIndex = 8;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // listBoxSag
            // 
            listBoxSag.FormattingEnabled = true;
            listBoxSag.Location = new Point(903, 39);
            listBoxSag.Name = "listBoxSag";
            listBoxSag.Size = new Size(298, 279);
            listBoxSag.TabIndex = 16;
            // 
            // buttonSagEkle
            // 
            buttonSagEkle.Location = new Point(752, 109);
            buttonSagEkle.Name = "buttonSagEkle";
            buttonSagEkle.Size = new Size(131, 56);
            buttonSagEkle.TabIndex = 17;
            buttonSagEkle.Text = ">>>";
            buttonSagEkle.UseVisualStyleBackColor = true;
            buttonSagEkle.Click += buttonSagEkle_Click;
            // 
            // buttonSolEkle
            // 
            buttonSolEkle.Location = new Point(752, 187);
            buttonSolEkle.Name = "buttonSolEkle";
            buttonSolEkle.Size = new Size(131, 56);
            buttonSolEkle.TabIndex = 18;
            buttonSolEkle.Text = "<<<";
            buttonSolEkle.UseVisualStyleBackColor = true;
            buttonSolEkle.Click += buttonSolEkle_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 512);
            Controls.Add(buttonSolEkle);
            Controls.Add(buttonSagEkle);
            Controls.Add(listBoxSag);
            Controls.Add(textBox1);
            Controls.Add(listBoxSol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSirala);
            Controls.Add(buttonSil);
            Controls.Add(buttonEkle);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBoxSol;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSirala;
        private Button buttonSil;
        private Button buttonEkle;
        private ListBox listBoxSag;
        private Button buttonSagEkle;
        private Button buttonSolEkle;
    }
}