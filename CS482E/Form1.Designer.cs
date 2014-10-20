namespace CS482E
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblkaraktersayisi = new System.Windows.Forms.Label();
            this.btnanaliz = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbdurum = new System.Windows.Forms.ComboBox();
            this.rbbosluklu = new System.Windows.Forms.RadioButton();
            this.rbbosluksuz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 142);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblkaraktersayisi
            // 
            this.lblkaraktersayisi.AutoSize = true;
            this.lblkaraktersayisi.Location = new System.Drawing.Point(9, 157);
            this.lblkaraktersayisi.Name = "lblkaraktersayisi";
            this.lblkaraktersayisi.Size = new System.Drawing.Size(94, 13);
            this.lblkaraktersayisi.TabIndex = 1;
            this.lblkaraktersayisi.Text = "500 Karakter Kaldı";
            // 
            // btnanaliz
            // 
            this.btnanaliz.Location = new System.Drawing.Point(197, 172);
            this.btnanaliz.Name = "btnanaliz";
            this.btnanaliz.Size = new System.Drawing.Size(75, 23);
            this.btnanaliz.TabIndex = 2;
            this.btnanaliz.Text = "Analiz";
            this.btnanaliz.UseVisualStyleBackColor = true;
            this.btnanaliz.Click += new System.EventHandler(this.btnanaliz_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(278, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 142);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Karakter";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Frekans";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yüzde";
            // 
            // cbdurum
            // 
            this.cbdurum.FormattingEnabled = true;
            this.cbdurum.Items.AddRange(new object[] {
            "En çok tekrar eden karakterler",
            "En az tekrar eden karakterler",
            "En çok tekrar eden iki harfli ",
            "En çok tekrar eden üç harfli"});
            this.cbdurum.Location = new System.Drawing.Point(12, 174);
            this.cbdurum.Name = "cbdurum";
            this.cbdurum.Size = new System.Drawing.Size(179, 21);
            this.cbdurum.TabIndex = 4;
            // 
            // rbbosluklu
            // 
            this.rbbosluklu.AutoSize = true;
            this.rbbosluklu.Location = new System.Drawing.Point(18, 201);
            this.rbbosluklu.Name = "rbbosluklu";
            this.rbbosluklu.Size = new System.Drawing.Size(65, 17);
            this.rbbosluklu.TabIndex = 5;
            this.rbbosluklu.TabStop = true;
            this.rbbosluklu.Text = "Boşluklu";
            this.rbbosluklu.UseVisualStyleBackColor = true;
            // 
            // rbbosluksuz
            // 
            this.rbbosluksuz.AutoSize = true;
            this.rbbosluksuz.Location = new System.Drawing.Point(89, 201);
            this.rbbosluksuz.Name = "rbbosluksuz";
            this.rbbosluksuz.Size = new System.Drawing.Size(73, 17);
            this.rbbosluksuz.TabIndex = 6;
            this.rbbosluksuz.TabStop = true;
            this.rbbosluksuz.Text = "Boşluksuz";
            this.rbbosluksuz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asil Arslan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbbosluksuz);
            this.Controls.Add(this.rbbosluklu);
            this.Controls.Add(this.cbdurum);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnanaliz);
            this.Controls.Add(this.lblkaraktersayisi);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS482E ASSIGNMENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblkaraktersayisi;
        private System.Windows.Forms.Button btnanaliz;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbdurum;
        private System.Windows.Forms.RadioButton rbbosluklu;
        private System.Windows.Forms.RadioButton rbbosluksuz;
        private System.Windows.Forms.Label label1;
    }
}

