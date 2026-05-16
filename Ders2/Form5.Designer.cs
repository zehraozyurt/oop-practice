namespace Ders2
{
    partial class Form5
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
            labelTc = new Label();
            labelAdı = new Label();
            labelSayad = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTc
            // 
            labelTc.AutoSize = true;
            labelTc.Location = new Point(51, 50);
            labelTc.Name = "labelTc";
            labelTc.Size = new Size(41, 25);
            labelTc.TabIndex = 0;
            labelTc.Text = "Tc  :";
            // 
            // labelAdı
            // 
            labelAdı.AutoSize = true;
            labelAdı.Location = new Point(51, 108);
            labelAdı.Name = "labelAdı";
            labelAdı.Size = new Size(53, 25);
            labelAdı.TabIndex = 1;
            labelAdı.Text = "Adı : ";
            // 
            // labelSayad
            // 
            labelSayad.AutoSize = true;
            labelSayad.Location = new Point(51, 169);
            labelSayad.Name = "labelSayad";
            labelSayad.Size = new Size(80, 25);
            labelSayad.TabIndex = 2;
            labelSayad.Text = "Soyadı : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 31);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(83, 234);
            button1.Name = "button1";
            button1.Size = new Size(244, 89);
            button1.TabIndex = 6;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(506, 321);
            dataGridView1.TabIndex = 7;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 449);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelSayad);
            Controls.Add(labelAdı);
            Controls.Add(labelTc);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTc;
        private Label labelAdı;
        private Label labelSayad;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
    }
}