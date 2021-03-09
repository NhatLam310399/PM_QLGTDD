using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QLGTDD
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        string placeholder = "Nhập vào đây...";
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
            loadM04();
        }


        void loadM04() {
            List<TextBox> lstTxt = new List<TextBox>();
            lstTxt.Add(M04_NSD_txt_diaChi);
            lstTxt.Add(M04_NSD_txt_hoTen);
            lstTxt.Add(M04_NSD_txt_so);
            lstTxt.Add(M04_txt_CLN_dt);
            lstTxt.Add(M04_txt_CLN_loaicay);
            lstTxt.Add(M04_txt_CLN_soHuuChung);
            lstTxt.Add(M04_txt_CLN_soHuuRieng);
            lstTxt.Add(M04_txt_cua);
            lstTxt.Add(M04_txt_deNghiKhac);
            lstTxt.Add(M04_txt_diaChiDat);
            lstTxt.Add(M04_txt_dtDat);
            lstTxt.Add(M04_txt_hoTenNguoiVD);
            lstTxt.Add(M04_txt_kinhGui);
            lstTxt.Add(M04_txt_ndQuyenSD);
            lstTxt.Add(M04_txt_nguonGocSD);
            lstTxt.Add(M04_txt_nhuCauGhiNo);
            lstTxt.Add(M04_txt_NO_dtSan);
            lstTxt.Add(M04_txt_NO_dtXD);
            lstTxt.Add(M04_txt_NO_ketCau);
            lstTxt.Add(M04_txt_NO_loaiNhaO);
            lstTxt.Add(M04_txt_NO_soHuuChung);
            lstTxt.Add(M04_txt_NO_soHuuRieng);
            lstTxt.Add(M04_txt_NO_soTang);
            lstTxt.Add(M04_txt_quyenSo);
            lstTxt.Add(M04_txt_RSX_dienTich);
            //lstTxt.Add(M04_txt_RSX_loaiCay);
            //lstTxt.Add(M04_NSD_txt_diaChi);
            //lstTxt.Add(M04_NSD_txt_diaChi);
            //lstTxt.Add(M04_NSD_txt_diaChi);
            //lstTxt.Add(M04_NSD_txt_diaChi);
            //lstTxt.Add(M04_NSD_txt_diaChi);
            //lstTxt.Add(M04_NSD_txt_diaChi);


            for (int l = 0; l < lstTxt.Count; l++)
            {
                if (l > 0)
                {
                    lstTxt[l].Text = placeholder;
                    lstTxt[l].ForeColor = Color.Gray;
                    lstTxt[l].Font = new Font(lstTxt[l].Font, FontStyle.Italic);
                }
            }

        }


    }
}
