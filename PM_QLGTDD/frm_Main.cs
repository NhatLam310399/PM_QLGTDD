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
using PM_QLGTDD.Library;
namespace PM_QLGTDD
{
    public partial class frm_Main : Form
    {
        UF_MauSo4a ufm04 = new UF_MauSo4a();
        DAL_saveDB_M04 dal = new DAL_saveDB_M04();
        WordExport we = new WordExport();
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
            M04_btn_quaylai.Enabled = false;
            M04_btn_xem.Enabled = false;
            M04_btn_sua.Enabled = false;
            M04_btn_xoa.Enabled = false;
            


        }
        private void M04_btn_Nhap_Click(object sender, EventArgs e)
        {
            pnl_container_M04.Controls.Clear();
            UF_MauSo4a ufm4a = new UF_MauSo4a();
            pnl_container_M04.Controls.Add(ufm4a);
            //ufm4a.Dock = DockStyle.Fill;
            pnl_container_M04.AutoScroll = true;
            M04_btn_quaylai.Enabled = true;

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
                        //filesPDF_mau04.setPageMode("none");
                        filesPDF_mau04.UseWaitCursor = true;
                        //filesPDF_mau04.
                        this.Refresh();
                    }
                    break;
                   
            }
           
        }

        private void M04_btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void M04_btn_xem_Click(object sender, EventArgs e)
        {
            List<BIEUMAU_M04> lstbm = dal.loadInfo_m04().ToList();
            foreach (var item in lstbm)
            {

                string KinhGui = item.KINHGUI;
                string So = item.SO;
                string QuyenSo = item.QUYENSO.ToString();
                string HoTen_NV = item.HOTEN_NVD;
                string HoTen = item.HOTEN_NVD;
                string DiaChi = item.DIACHI_NVD;
                string ThuaDatSo = item.THUADATSO.ToString();
                string ToBanDoSo = item.TOBANDOSO;
                string DiaChiThuaDat = item.DIACHI_THUADAT;
                string DienTich_TD = item.DT_TD.ToString();
                string SDChung = item.SHCHUNG_TD.ToString();
                string SDRieng = item.SHRIENG_TD.ToString();
                string SDMD = item.MUCDICHSD;
                string TuThoiDiem = item.TUTHOIDIEM_TD.ToString();
                string THDNSD = item.THOIHANDENGHISD_TD;
                string LoaiNhaO = "";
                string DTNhaO = "";
                string DTSan = "";
                string NOSDChung = "";
                string NOSDRieng = "";
                string NOKetCau = "";
                string NOSoTang = "";
                string NOThoiHanSH = "";
                string RXSLoaiCay = "";
                string RXSDienTich = "";
                string CLNLoaiCay = "";
                string RXSSHChung = "";
                string RXSSHRieng = "";
                string RXSThoiGianSH = "";
                string CLNDienTich = "";
                string CLNSHChung = "";
                string CLNSHRieng = "";
                string CLNThoiGianSH = "";
                string cua = item.CUA_TD;
                string ndsd = item.NDQUYENSD_TD;
                string nguongoc = item.NGUONGOC_TD;
                if (item.LOAINHAO_NO != null)
                {
                    LoaiNhaO = item.LOAINHAO_NO;//
                }
                if (item.SHRIENG_NO != null)
                {
                    NOSDRieng = item.SHRIENG_NO.ToString();//
                }
                if (item.SHRIENG_CLN != null)
                {
                    CLNSHRieng = item.SHRIENG_CLN.ToString();//
                }


                if (item.DTXAYDUNG_NO != 0)
                {
                    DTNhaO = item.DTXAYDUNG_NO.ToString();//
                }


                if (item.DTSAN_NO != 0)
                {
                    DTSan = item.DTSAN_NO.ToString();//
                }


                if (item.SHCHUNG_NO != 0)
                {
                    NOSDChung = item.SHCHUNG_NO.ToString();//
                }


                if (item.SHRIENG_NO != 0)
                {
                    NOSDRieng = item.SHRIENG_NO.ToString();//
                }


                if (item.KETCAU_NO != null)
                {
                    NOKetCau = item.KETCAU_NO;//
                }


                if (item.SOTANG_NO != 0)
                {
                    NOSoTang = item.SOTANG_NO.ToString();//
                }


                if (item.THOIHANSDDEN_NO != null)
                {
                    NOThoiHanSH = item.THOIHANSDDEN_NO;//
                }


                if (item.LOAICAY_RSX != null)
                {
                    RXSLoaiCay = item.LOAICAY_RSX;//
                }


                if (item.DT_RSX != 0)
                {
                    RXSDienTich = item.DT_RSX.ToString();//
                }


                if (item.LOAICAY_CLN != null)
                {
                    CLNLoaiCay = item.LOAICAY_CLN;//
                }


                if (item.SDCHUNG_RSX != 0)
                {
                    RXSSHChung = item.SDCHUNG_RSX.ToString();//
                }


                if (item.SDRIENG_RSX != 0)
                {
                    RXSSHRieng = item.SDRIENG_RSX.ToString();//
                }

                if (item.THOIHANSDDEN_RSX != null)
                {
                    RXSThoiGianSH = item.THOIHANSDDEN_RSX;//
                }


                if (item.DT_CLN != 0)
                {
                    CLNDienTich = item.DT_CLN.ToString();//
                }


                if (item.SHCHUNG_CLN != 0)
                {
                    CLNSHChung = item.SHCHUNG_CLN.ToString();//
                }


                if (item.SHRIENG_CLN != 0)
                {
                    CLNSHRieng = item.SHRIENG_CLN.ToString();//
                }


                if (item.THOIHANSDDEN_CLN != null)
                {
                    CLNThoiGianSH = item.THOIHANSDDEN_CLN;//
                }



                string GiayToKemTheo = item.GIAYTOKEMTHEO;
                string NhuCauGhiNo = item.NHU_CAU_GHI_NO;
                string DeNghiKhac = item.DENGHIKHAC;

                string NgayV = " ";
                if (item.NGAYVIETDON.Value.Day > 10)
                {
                    NgayV = item.NGAYVIETDON.Value.Day.ToString();
                }
                else { NgayV = "0" + item.NGAYVIETDON.Value.Day; }

                string ThangV = " ";
                if (item.NGAYVIETDON.Value.Month > 10)
                {
                    ThangV = item.NGAYVIETDON.Value.Month.ToString();
                }
                else
                {
                    ThangV = "0" + item.NGAYVIETDON.Value.Month;
                }

                string NamV = item.NGAYVIETDON.Value.Year.ToString();


                //ufm04.xuatFiles();
                //MessageBox.Show("Đã xuất file thành công!");
                if (we.MauSo4a(KinhGui, So, QuyenSo, HoTen_NV, HoTen.ToUpper(), DiaChi, ThuaDatSo, ToBanDoSo, DiaChiThuaDat, DienTich_TD,
                     SDChung, SDRieng, SDMD, TuThoiDiem, THDNSD, LoaiNhaO, DTNhaO, DTSan, NOSDChung, NOSDRieng, NOKetCau, NOSoTang, NOThoiHanSH,
                     RXSLoaiCay, RXSDienTich, CLNLoaiCay, RXSSHChung, RXSSHRieng, RXSThoiGianSH, CLNDienTich, CLNSHChung, CLNSHRieng, CLNThoiGianSH, cua,
                     ndsd, nguongoc, GiayToKemTheo, NhuCauGhiNo, DeNghiKhac, ThangV, NgayV, NamV))
                {
                    MessageBox.Show("Xuất file thành công !");
                }
                else
                {
                    MessageBox.Show("Xuất file thất bại !");
                }
            }
        }
        private void M04_btn_sua_Click(object sender, EventArgs e)
        {

        }
    }
}
