using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QLGTDD.MauSo4a
{
    public partial class UF_MauSo4a : UserControl
    {
        public UF_MauSo4a uf_m4;
        List<TextBox> lstTxt;
        string placeholder = "Nhập tại đây...";
       
        
        
        public UF_MauSo4a()
        { 
            InitializeComponent();

        }
       
        private void UF_MauSo4a_Load(object sender, EventArgs e)
        {
            loadM04();
        }
        void loadM04()
        {
            lstTxt = new List<TextBox>();
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
            lstTxt.Add(M04_txt_RSX_loaiCay);
            lstTxt.Add(M04_txt_RSX_nguonVon);
            lstTxt.Add(M04_txt_RSX_nhanChuyenQuyen);
            lstTxt.Add(M04_txt_RSX_NNKTT);
            lstTxt.Add(M04_txt_RSX_NNTT);
            lstTxt.Add(M04_txt_RSX_soHuuChung);
            lstTxt.Add(M04_txt_RSX_soHuuRieng);
            lstTxt.Add(M04_txt_RSX_tuTrong);
            lstTxt.Add(M04_txt_sdHanChe);
            lstTxt.Add(M04_txt_suDungChung);
            lstTxt.Add(M04_txt_suDungMD);
            lstTxt.Add(M04_txt_suDungRieng);
            lstTxt.Add(M04_txt_ThuaDatDK);
            lstTxt.Add(M04_txt_thuaDatSo);
            lstTxt.Add(M04_txt_toBanDoSo);
            lstTxt.Add(M04_NSD_txt_diaChi);
            lstTxt.Add(Mau04_txt_giayTokemTheo);
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

        private void M04_txt_quyenSo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_quyenSo.Clear();
            M04_txt_quyenSo.Font = new Font(M04_txt_quyenSo.Font, FontStyle.Regular);
            M04_txt_quyenSo.ForeColor = Color.Black;
        }
        private void M04_NSD_txt_so_MouseClick(object sender, MouseEventArgs e)
        {
            M04_NSD_txt_so.Clear();
            M04_NSD_txt_so.Font = new Font(M04_NSD_txt_so.Font, FontStyle.Regular);
            M04_NSD_txt_so.ForeColor = Color.Black;
        }

        private void M04_txt_hoTenNguoiVD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_hoTenNguoiVD.Clear();
            M04_txt_hoTenNguoiVD.Font = new Font(M04_txt_hoTenNguoiVD.Font, FontStyle.Regular);
            M04_txt_hoTenNguoiVD.ForeColor = Color.Black;
        }

        private void M04_txt_kinhGui_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_kinhGui.Clear();
            M04_txt_kinhGui.Font = new Font(M04_txt_kinhGui.Font, FontStyle.Regular);
            M04_txt_kinhGui.ForeColor = Color.Black;
        }

        private void M04_NSD_txt_hoTen_MouseClick(object sender, MouseEventArgs e)
        {
            M04_NSD_txt_hoTen.Clear();
            M04_NSD_txt_hoTen.Font = new Font(M04_NSD_txt_hoTen.Font, FontStyle.Regular);
            M04_NSD_txt_hoTen.ForeColor = Color.Black;
        }

        private void M04_NSD_txt_diaChi_MouseClick(object sender, MouseEventArgs e)
        {
            M04_NSD_txt_diaChi.Clear();
            M04_NSD_txt_diaChi.Font = new Font(M04_NSD_txt_diaChi.Font, FontStyle.Regular);
            M04_NSD_txt_diaChi.ForeColor = Color.Black;
        }

        private void M04_txt_ThuaDatDK_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_ThuaDatDK.Clear();
            M04_txt_ThuaDatDK.Font = new Font(M04_txt_ThuaDatDK.Font, FontStyle.Regular);
            M04_txt_ThuaDatDK.ForeColor = Color.Black;
        }

        private void M04_txt_thuaDatSo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_thuaDatSo.Clear();
            M04_txt_thuaDatSo.Font = new Font(M04_txt_thuaDatSo.Font, FontStyle.Regular);
            M04_txt_thuaDatSo.ForeColor = Color.Black;
        }

        private void M04_txt_toBanDoSo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_toBanDoSo.Clear();
            M04_txt_toBanDoSo.Font = new Font(M04_txt_toBanDoSo.Font, FontStyle.Regular);
            M04_txt_toBanDoSo.ForeColor = Color.Black;
        }

        private void M04_txt_diaChiDat_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_diaChiDat.Clear();
            M04_txt_diaChiDat.Font = new Font(M04_txt_diaChiDat.Font, FontStyle.Regular);
            M04_txt_diaChiDat.ForeColor = Color.Black;
        }

        private void M04_txt_dtDat_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_dtDat.Clear();
            M04_txt_dtDat.Font = new Font(M04_txt_dtDat.Font, FontStyle.Regular);
            M04_txt_dtDat.ForeColor = Color.Black;
        }

        private void M04_txt_suDungChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungChung.Clear();
            M04_txt_suDungChung.Font = new Font(M04_txt_suDungChung.Font, FontStyle.Regular);
            M04_txt_suDungChung.ForeColor = Color.Black;
        }

        private void M04_txt_suDungRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungRieng.Clear();
            M04_txt_suDungRieng.Font = new Font(M04_txt_suDungRieng.Font, FontStyle.Regular);
            M04_txt_suDungRieng.ForeColor = Color.Black;
        }

        private void M04_txt_suDungMD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungMD.Clear();
            M04_txt_suDungMD.Font = new Font(M04_txt_suDungMD.Font, FontStyle.Regular);
            M04_txt_suDungMD.ForeColor = Color.Black;
        }

        private void M04_txt_nguonGocSD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_nguonGocSD.Clear();
            M04_txt_nguonGocSD.Font = new Font(M04_txt_nguonGocSD.Font, FontStyle.Regular);
            M04_txt_nguonGocSD.ForeColor = Color.Black;
        }

        private void M04_txt_sdHanChe_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_sdHanChe.Clear();
            M04_txt_sdHanChe.Font = new Font(M04_txt_sdHanChe.Font, FontStyle.Regular);
            M04_txt_sdHanChe.ForeColor = Color.Black;
        }

        private void M04_txt_cua_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_cua.Clear();
            M04_txt_cua.Font = new Font(M04_txt_cua.Font, FontStyle.Regular);
            M04_txt_cua.ForeColor = Color.Black;
        }

        private void M04_txt_ndQuyenSD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_ndQuyenSD.Clear();
            M04_txt_ndQuyenSD.Font = new Font(M04_txt_ndQuyenSD.Font, FontStyle.Regular);
            M04_txt_ndQuyenSD.ForeColor = Color.Black;
        }

        private void M04_txt_NO_loaiNhaO_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_loaiNhaO.Clear();
            M04_txt_NO_loaiNhaO.Font = new Font(M04_txt_NO_loaiNhaO.Font, FontStyle.Regular);
            M04_txt_NO_loaiNhaO.ForeColor = Color.Black;
        }

        private void M04_txt_NO_dtXD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_dtXD.Clear();
            M04_txt_NO_dtXD.Font = new Font(M04_txt_NO_dtXD.Font, FontStyle.Regular);
            M04_txt_NO_dtXD.ForeColor = Color.Black;
        }

        private void M04_txt_NO_dtSan_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_dtSan.Clear();
            M04_txt_NO_dtSan.Font = new Font(M04_txt_NO_dtSan.Font, FontStyle.Regular);
            M04_txt_NO_dtSan.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soHuuChung.Clear();
            M04_txt_NO_soHuuChung.Font = new Font(M04_txt_NO_soHuuChung.Font, FontStyle.Regular);
            M04_txt_NO_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soHuuRieng.Clear();
            M04_txt_NO_soHuuRieng.Font = new Font(M04_txt_NO_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_NO_soHuuRieng.ForeColor = Color.Black;
        }

        private void M04_txt_NO_ketCau_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_ketCau.Clear();
            M04_txt_NO_ketCau.Font = new Font(M04_txt_NO_ketCau.Font, FontStyle.Regular);
            M04_txt_NO_ketCau.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soTang_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soTang.Clear();
            M04_txt_NO_soTang.Font = new Font(M04_txt_NO_soTang.Font, FontStyle.Regular);
            M04_txt_NO_soTang.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_loaiCay_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_loaiCay.Clear();
            M04_txt_RSX_loaiCay.Font = new Font(M04_txt_RSX_loaiCay.Font, FontStyle.Regular);
            M04_txt_RSX_loaiCay.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_dienTich_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_dienTich.Clear();
            M04_txt_RSX_dienTich.Font = new Font(M04_txt_RSX_dienTich.Font, FontStyle.Regular);
            M04_txt_RSX_dienTich.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_tuTrong_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_tuTrong.Clear();
            M04_txt_RSX_tuTrong.Font = new Font(M04_txt_RSX_tuTrong.Font, FontStyle.Regular);
            M04_txt_RSX_tuTrong.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_NNKTT_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_NNKTT.Clear();
            M04_txt_RSX_NNKTT.Font = new Font(M04_txt_RSX_NNKTT.Font, FontStyle.Regular);
            M04_txt_RSX_NNKTT.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_NNTT_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_NNTT.Clear();
            M04_txt_RSX_NNTT.Font = new Font(M04_txt_RSX_NNTT.Font, FontStyle.Regular);
            M04_txt_RSX_NNTT.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_nhanChuyenQuyen_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_nhanChuyenQuyen.Clear();
            M04_txt_RSX_nhanChuyenQuyen.Font = new Font(M04_txt_RSX_nhanChuyenQuyen.Font, FontStyle.Regular);
            M04_txt_RSX_nhanChuyenQuyen.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_nguonVon_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_nguonVon.Clear();
            M04_txt_RSX_nguonVon.Font = new Font(M04_txt_RSX_nguonVon.Font, FontStyle.Regular);
            M04_txt_RSX_nguonVon.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_soHuuChung.Clear();
            M04_txt_RSX_soHuuChung.Font = new Font(M04_txt_RSX_soHuuChung.Font, FontStyle.Regular);
            M04_txt_RSX_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_soHuuRieng.Clear();
            M04_txt_RSX_soHuuRieng.Font = new Font(M04_txt_RSX_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_RSX_soHuuRieng.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_loaicay_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_loaicay.Clear();
            M04_txt_CLN_loaicay.Font = new Font(M04_txt_CLN_loaicay.Font, FontStyle.Regular);
            M04_txt_CLN_loaicay.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_dt_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_dt.Clear();
            M04_txt_CLN_dt.Font = new Font(M04_txt_CLN_dt.Font, FontStyle.Regular);
            M04_txt_CLN_dt.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_soHuuChung.Clear();
            M04_txt_CLN_soHuuChung.Font = new Font(M04_txt_CLN_soHuuChung.Font, FontStyle.Regular);
            M04_txt_CLN_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_soHuuRieng.Clear();
            M04_txt_CLN_soHuuRieng.Font = new Font(M04_txt_CLN_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_CLN_soHuuRieng.ForeColor = Color.Black;
        }

        private void Mau04_txt_giayTokemTheo_MouseClick(object sender, MouseEventArgs e)
        {
            Mau04_txt_giayTokemTheo.Clear();
            Mau04_txt_giayTokemTheo.Font = new Font(Mau04_txt_giayTokemTheo.Font, FontStyle.Regular);
            Mau04_txt_giayTokemTheo.ForeColor = Color.Black;
        }

        private void M04_txt_nhuCauGhiNo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_nhuCauGhiNo.Clear();
            M04_txt_nhuCauGhiNo.Font = new Font(M04_txt_nhuCauGhiNo.Font, FontStyle.Regular);
            M04_txt_nhuCauGhiNo.ForeColor = Color.Black;
        }

        private void M04_txt_deNghiKhac_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_deNghiKhac.Clear();
            M04_txt_deNghiKhac.Font = new Font(M04_txt_deNghiKhac.Font, FontStyle.Regular);
            M04_txt_deNghiKhac.ForeColor = Color.Black;
        }

        private void M04_btn_Luu_Click(object sender, EventArgs e)
        {
            frm_Main fMain = new frm_Main();
            fMain.Sender(M04_txt_quyenSo.Text, M04_NSD_txt_so.Text);
                
        }
    }
}
