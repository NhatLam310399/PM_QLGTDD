using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QLGTDD.MauSo4a;
//using Microsoft.Office.Interop.Word;
namespace PM_QLGTDD
{
    public partial class frm_Main : Form
    {
        UF_MauSo4a ufm04 = new UF_MauSo4a();
        public frm_Main()
        {
            InitializeComponent();
        }
        void styleLayout()
        {
            tableLayoutPanel2.BackColor = Color.FromArgb(39, 89, 167);
            tableLayoutPanel1.BackColor = Color.FromArgb(50, 118, 195); // color thanh công cụ
            //233,233,233 color mẫu đơn
        }
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                frm_Main.ActiveForm.Close();
            }

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            styleLayout();
            


        }
        private void M04_btn_Nhap_Click(object sender, EventArgs e)
        {
            pnl_container_M04.Controls.Clear();
            UF_MauSo4a ufm4a = new UF_MauSo4a();
            pnl_container_M04.Controls.Add(ufm4a);
            //ufm4a.Dock = DockStyle.Fill;
            pnl_container_M04.AutoScroll = true;

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            int index = int.Parse(tabControl1.SelectedTab.Tag.ToString());
            switch (index)
            {
                //Mau 04
                case 5:
                    {
                        string path = System.IO.Path.GetFullPath("..\\..\\..\\template_mau\\MauSo4a.pdf");
                        filesPDF_mau04.src = path;
                        filesPDF_mau04.setPageMode("none");
                    }
                    break;
                   
            }
           
        }

        private void M04_btn_Luu_Click(object sender, EventArgs e)
        {
        }

        private void M04_btn_in_Click(object sender, EventArgs e)
        {
            if (ufm04.xuatFiles())
            {
                MessageBox.Show("Xuất file thành công! File đã được xuất ngoài màn hình chính của bạn");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại!");

            }
        }
    }
}
