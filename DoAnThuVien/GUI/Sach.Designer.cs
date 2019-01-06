namespace DoAnThuVien.GUI
{
    partial class Sach
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
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.cmbTheLoai = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txbTenSach = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button2 = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.txbTacGia = new System.Windows.Forms.TextBox();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(381, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(190, 25);
         this.label1.TabIndex = 0;
         this.label1.Text = "THÔNG TIN SÁCH";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.checkBox1);
         this.groupBox1.Controls.Add(this.txbTacGia);
         this.groupBox1.Controls.Add(this.button1);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.cmbTheLoai);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.txbTenSach);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Location = new System.Drawing.Point(12, 46);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(209, 213);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Tìm Sách";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(115, 154);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 6;
         this.button1.Text = "Tìm Kiếm";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 108);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(43, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "Tác giả";
         // 
         // cmbTheLoai
         // 
         this.cmbTheLoai.FormattingEnabled = true;
         this.cmbTheLoai.Location = new System.Drawing.Point(59, 71);
         this.cmbTheLoai.Name = "cmbTheLoai";
         this.cmbTheLoai.Size = new System.Drawing.Size(131, 21);
         this.cmbTheLoai.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 71);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(45, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Thể loại";
         // 
         // txbTenSach
         // 
         this.txbTenSach.Location = new System.Drawing.Point(59, 34);
         this.txbTenSach.Name = "txbTenSach";
         this.txbTenSach.Size = new System.Drawing.Size(131, 20);
         this.txbTenSach.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 34);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Từ khóa";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.button2);
         this.groupBox2.Controls.Add(this.dataGridView1);
         this.groupBox2.Location = new System.Drawing.Point(237, 46);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(692, 213);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Sách";
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(295, 171);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(118, 36);
         this.button2.TabIndex = 7;
         this.button2.Text = "Sửa Thông Tin Sách";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(6, 15);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(680, 150);
         this.dataGridView1.TabIndex = 0;
         // 
         // txbTacGia
         // 
         this.txbTacGia.Location = new System.Drawing.Point(59, 105);
         this.txbTacGia.Name = "txbTacGia";
         this.txbTacGia.Size = new System.Drawing.Size(131, 20);
         this.txbTacGia.TabIndex = 7;
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Location = new System.Drawing.Point(59, 131);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(99, 17);
         this.checkBox1.TabIndex = 8;
         this.checkBox1.Text = "Tìm tất cả sách";
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // Sach
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(941, 271);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.Name = "Sach";
         this.Text = "Sach";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox txbTacGia;
      private System.Windows.Forms.CheckBox checkBox1;
   }
}