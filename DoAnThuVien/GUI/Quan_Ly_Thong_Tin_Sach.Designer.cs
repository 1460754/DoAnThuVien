namespace DoAnThuVien.GUI
{
    partial class Quan_Ly_Thong_Tin_Sach
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
         this.button5 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.txbMa = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.txtGia = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.txbSoLuong = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.txtNamXB = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txbTacGia = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txbTen = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.comboBox3 = new System.Windows.Forms.ComboBox();
         this.label10 = new System.Windows.Forms.Label();
         this.comboBox4 = new System.Windows.Forms.ComboBox();
         this.label11 = new System.Windows.Forms.Label();
         this.textBox7 = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.txbNXB = new System.Windows.Forms.TextBox();
         this.txbTheLoai = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(135, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(445, 37);
         this.label1.TabIndex = 0;
         this.label1.Text = "QUẢN LÝ THÔNG TIN SÁCH";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txbTheLoai);
         this.groupBox1.Controls.Add(this.txbNXB);
         this.groupBox1.Controls.Add(this.button5);
         this.groupBox1.Controls.Add(this.button4);
         this.groupBox1.Controls.Add(this.button3);
         this.groupBox1.Controls.Add(this.button2);
         this.groupBox1.Controls.Add(this.txbMa);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Controls.Add(this.txtGia);
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.txbSoLuong);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.txtNamXB);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.txbTacGia);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.txbTen);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Location = new System.Drawing.Point(12, 168);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(635, 231);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Thông Tin Sách";
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(432, 180);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(75, 23);
         this.button5.TabIndex = 19;
         this.button5.Text = "Điền Lại";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(335, 180);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(75, 23);
         this.button4.TabIndex = 18;
         this.button4.Text = "Cập Nhật";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(237, 180);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 17;
         this.button3.Text = "Xóa";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(140, 180);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 16;
         this.button2.Text = "Thêm";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // txbMa
         // 
         this.txbMa.Location = new System.Drawing.Point(121, 31);
         this.txbMa.Name = "txbMa";
         this.txbMa.Size = new System.Drawing.Size(153, 20);
         this.txbMa.TabIndex = 15;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(39, 34);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(48, 13);
         this.label9.TabIndex = 14;
         this.label9.Text = "Mã sách";
         // 
         // txtGia
         // 
         this.txtGia.Location = new System.Drawing.Point(432, 140);
         this.txtGia.Name = "txtGia";
         this.txtGia.Size = new System.Drawing.Size(153, 20);
         this.txtGia.TabIndex = 13;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(350, 143);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(40, 13);
         this.label8.TabIndex = 12;
         this.label8.Text = "Giá bìa";
         // 
         // txbSoLuong
         // 
         this.txbSoLuong.Location = new System.Drawing.Point(432, 101);
         this.txbSoLuong.Name = "txbSoLuong";
         this.txbSoLuong.Size = new System.Drawing.Size(153, 20);
         this.txbSoLuong.TabIndex = 11;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(350, 107);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(49, 13);
         this.label7.TabIndex = 10;
         this.label7.Text = "Số lượng";
         // 
         // txtNamXB
         // 
         this.txtNamXB.Location = new System.Drawing.Point(432, 67);
         this.txtNamXB.Name = "txtNamXB";
         this.txtNamXB.Size = new System.Drawing.Size(153, 20);
         this.txtNamXB.TabIndex = 9;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(350, 70);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(73, 13);
         this.label6.TabIndex = 8;
         this.label6.Text = "Năm xuất bản";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(350, 30);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(71, 13);
         this.label5.TabIndex = 6;
         this.label5.Text = "Nhà xuất bản";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(39, 139);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(45, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "Thể loại";
         // 
         // txbTacGia
         // 
         this.txbTacGia.Location = new System.Drawing.Point(121, 101);
         this.txbTacGia.Name = "txbTacGia";
         this.txbTacGia.Size = new System.Drawing.Size(153, 20);
         this.txbTacGia.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(39, 104);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Tác giả";
         // 
         // txbTen
         // 
         this.txbTen.Location = new System.Drawing.Point(121, 64);
         this.txbTen.Name = "txbTen";
         this.txbTen.Size = new System.Drawing.Size(153, 20);
         this.txbTen.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(39, 67);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(52, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Tên sách";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Controls.Add(this.comboBox3);
         this.groupBox2.Controls.Add(this.label10);
         this.groupBox2.Controls.Add(this.comboBox4);
         this.groupBox2.Controls.Add(this.label11);
         this.groupBox2.Controls.Add(this.textBox7);
         this.groupBox2.Controls.Add(this.label12);
         this.groupBox2.Location = new System.Drawing.Point(18, 46);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(629, 107);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Tìm Sách";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(59, 73);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 6;
         this.button1.Text = "Tìm Kiếm";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // comboBox3
         // 
         this.comboBox3.FormattingEnabled = true;
         this.comboBox3.Location = new System.Drawing.Point(483, 34);
         this.comboBox3.Name = "comboBox3";
         this.comboBox3.Size = new System.Drawing.Size(131, 21);
         this.comboBox3.TabIndex = 5;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(430, 34);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(45, 13);
         this.label10.TabIndex = 4;
         this.label10.Text = "Tác giải";
         // 
         // comboBox4
         // 
         this.comboBox4.FormattingEnabled = true;
         this.comboBox4.Location = new System.Drawing.Point(281, 34);
         this.comboBox4.Name = "comboBox4";
         this.comboBox4.Size = new System.Drawing.Size(131, 21);
         this.comboBox4.TabIndex = 3;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(228, 34);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(45, 13);
         this.label11.TabIndex = 2;
         this.label11.Text = "Thể loại";
         // 
         // textBox7
         // 
         this.textBox7.Location = new System.Drawing.Point(59, 34);
         this.textBox7.Name = "textBox7";
         this.textBox7.Size = new System.Drawing.Size(131, 20);
         this.textBox7.TabIndex = 1;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(6, 34);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(47, 13);
         this.label12.TabIndex = 0;
         this.label12.Text = "Từ khóa";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.dataGridView1);
         this.groupBox3.Location = new System.Drawing.Point(662, 46);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(412, 351);
         this.groupBox3.TabIndex = 3;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Sách";
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(6, 15);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(400, 330);
         this.dataGridView1.TabIndex = 0;
         // 
         // txbNXB
         // 
         this.txbNXB.Location = new System.Drawing.Point(432, 27);
         this.txbNXB.Name = "txbNXB";
         this.txbNXB.Size = new System.Drawing.Size(153, 20);
         this.txbNXB.TabIndex = 20;
         // 
         // txbTheLoai
         // 
         this.txbTheLoai.Location = new System.Drawing.Point(121, 136);
         this.txbTheLoai.Name = "txbTheLoai";
         this.txbTheLoai.Size = new System.Drawing.Size(153, 20);
         this.txbTheLoai.TabIndex = 21;
         // 
         // Quan_Ly_Thong_Tin_Sach
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1092, 409);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.Name = "Quan_Ly_Thong_Tin_Sach";
         this.Text = "Quan_Ly_Thong_Tin_Sach";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.TextBox txbNXB;
      private System.Windows.Forms.TextBox txbTheLoai;
   }
}