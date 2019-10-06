using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("Nhập môn tin học");
            lstDanhSach.Items.Add("Tin học văn phòng");
            lstDanhSach.Items.Add("Lập trình Windows");
            lstDanhSach.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSach.Items.Add("Lập trình hướng đối tượng");
        }

        private void btnChonDonLe_Click(object sender, EventArgs e)
        {
            try
            {
                lstDanhSachChon.Items.Add(lstDanhSach.SelectedItem);
            }
            catch (Exception)
            {
           
            }
        }

        private void btnChonToanBo_Click(object sender, EventArgs e)
        {
            for (int i=0; i<lstDanhSach.Items.Count; i++)
            {
                lstDanhSachChon.Items.Add(lstDanhSach.Items[i]);
            }
        }

        private void btnXoaDonLe_Click(object sender, EventArgs e)
        {
            lstDanhSachChon.Items.Remove(lstDanhSachChon.SelectedItem);
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            lstDanhSachChon.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
