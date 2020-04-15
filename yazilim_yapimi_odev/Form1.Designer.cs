namespace yazilim_yapimi_odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rastgeleBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.harflerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kelimeEkleBtn = new System.Windows.Forms.Button();
            this.veriCekBtn = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yeniOyunBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rastgeleBtn
            // 
            this.rastgeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rastgeleBtn.Location = new System.Drawing.Point(31, 426);
            this.rastgeleBtn.Name = "rastgeleBtn";
            this.rastgeleBtn.Size = new System.Drawing.Size(240, 39);
            this.rastgeleBtn.TabIndex = 0;
            this.rastgeleBtn.Text = "Rastgele Oluştur";
            this.rastgeleBtn.UseVisualStyleBackColor = true;
            this.rastgeleBtn.Click += new System.EventHandler(this.rastgeleBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 251);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(337, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 3;
            // 
            // harflerTxt
            // 
            this.harflerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harflerTxt.Location = new System.Drawing.Point(73, 334);
            this.harflerTxt.Name = "harflerTxt";
            this.harflerTxt.Size = new System.Drawing.Size(157, 22);
            this.harflerTxt.TabIndex = 5;
            this.harflerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(118, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harfler";
            // 
            // kelimeEkleBtn
            // 
            this.kelimeEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeEkleBtn.Location = new System.Drawing.Point(31, 372);
            this.kelimeEkleBtn.Name = "kelimeEkleBtn";
            this.kelimeEkleBtn.Size = new System.Drawing.Size(240, 39);
            this.kelimeEkleBtn.TabIndex = 7;
            this.kelimeEkleBtn.Text = "Kelimeleri Ekle";
            this.kelimeEkleBtn.UseVisualStyleBackColor = true;
            this.kelimeEkleBtn.Click += new System.EventHandler(this.kelimeEkleBtn_Click);
            // 
            // veriCekBtn
            // 
            this.veriCekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriCekBtn.Location = new System.Drawing.Point(452, 308);
            this.veriCekBtn.Name = "veriCekBtn";
            this.veriCekBtn.Size = new System.Drawing.Size(227, 52);
            this.veriCekBtn.TabIndex = 8;
            this.veriCekBtn.Text = "Verileri Çek";
            this.veriCekBtn.UseVisualStyleBackColor = true;
            this.veriCekBtn.Click += new System.EventHandler(this.veriCekBtn_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(328, 403);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(460, 173);
            this.listBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(464, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Veritabanı Ile Eşleşenler";
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleBtn.Location = new System.Drawing.Point(31, 481);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(240, 39);
            this.listeleBtn.TabIndex = 12;
            this.listeleBtn.Text = "Eşleşenleri Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(518, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Veritabanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Oluşturulan Kelimeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 251);
            this.dataGridView1.TabIndex = 16;
            // 
            // yeniOyunBtn
            // 
            this.yeniOyunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyunBtn.Location = new System.Drawing.Point(31, 537);
            this.yeniOyunBtn.Name = "yeniOyunBtn";
            this.yeniOyunBtn.Size = new System.Drawing.Size(240, 39);
            this.yeniOyunBtn.TabIndex = 17;
            this.yeniOyunBtn.Text = "Yeni Oyun";
            this.yeniOyunBtn.UseVisualStyleBackColor = true;
            this.yeniOyunBtn.Click += new System.EventHandler(this.yeniOyunBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 598);
            this.Controls.Add(this.yeniOyunBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.veriCekBtn);
            this.Controls.Add(this.kelimeEkleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.harflerTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rastgeleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rastgeleBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harflerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kelimeEkleBtn;
        private System.Windows.Forms.Button veriCekBtn;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button yeniOyunBtn;
    }
}

