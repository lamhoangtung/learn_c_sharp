using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbPhongBan.Items.Add("Phòng tài vụ");
            cmbPhongBan.Items.Add("Phòng hành chính");
            cmbPhongBan.Items.Add("Phòng kinh doanh");
            cmbPhongBan.Items.Add("Phòng kĩ thuật");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string st = txtHoTen.Text + " - " + cmbGioiTinh.Text + " - " + cmbPhongBan.Text;
            lstNhanVien.Items.Add(st);
        }
    }
}
