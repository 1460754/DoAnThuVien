using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThuVien.GUI
{
    public partial class Quan_Ly_Thong_Tin_Sach : Form
    {
        public Quan_Ly_Thong_Tin_Sach()
        {
            InitializeComponent();
        }

      private void button2_Click(object sender, EventArgs e)
      {
         SachDto sachDto = new SachDto();
        // sachDto.ID = textBox1.Text;

      }
   }
}
