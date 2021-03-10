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

namespace PM_QLGTDD
{
    public partial class frm_Main : Form
    {
        public delegate void sendInfo(string quyenso, string so);
        public sendInfo Sender;
        
        public frm_Main()
        {

            InitializeComponent();
            Sender = new sendInfo(getInfo);
        }

        string _quyenso, _so;
        public void getInfo(string quyenso, string so)
        {
            _quyenso = quyenso;
            _so = so;
        }
        void readerdemo()
        {
            MessageBox.Show(_quyenso, _so);
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
           
            readerdemo();
        }
    }
}
