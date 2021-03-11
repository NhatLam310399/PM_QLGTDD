using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Globalization;
using DataTable = System.Data.DataTable;

namespace PM_QLGTDD.MauSo4a
{
    public partial class UF_MauSo4a : UserControl
    {
        public UF_MauSo4a uf_m4;
        List<TextBox> lstTxt;
        string placeholder = "Nhập tại đây...";
        private readonly string path = System.Windows.Forms.Application.StartupPath + "\\template_out\\MauSo4a.docx";

        DAL_saveDB_M04 dal = new DAL_saveDB_M04();
        
        
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
                    lstTxt[l].Font = new System.Drawing.Font(lstTxt[l].Font,FontStyle.Italic);
                }
            }

        }

        private void M04_txt_quyenSo_MouseClick(object sender, MouseEventArgs e)
        {
            if (M04_txt_quyenSo.Text == placeholder)
            {
                M04_txt_quyenSo.Clear();
                M04_txt_quyenSo.Font = new System.Drawing.Font(M04_txt_quyenSo.Font, FontStyle.Regular);
                M04_txt_quyenSo.ForeColor = Color.Black;
            }

        }
        private void M04_NSD_txt_so_MouseClick(object sender, MouseEventArgs e)
        {
            if (M04_NSD_txt_so.Text == placeholder)
            {
                M04_NSD_txt_so.Clear();
                M04_NSD_txt_so.Font = new System.Drawing.Font(M04_NSD_txt_so.Font, FontStyle.Regular);
                M04_NSD_txt_so.ForeColor = Color.Black;
            }
        }

        private void M04_txt_hoTenNguoiVD_MouseClick(object sender, MouseEventArgs e)
        {
            if (M04_txt_hoTenNguoiVD.Text == placeholder)
            {
                M04_txt_hoTenNguoiVD.Clear();
                M04_txt_hoTenNguoiVD.Font = new System.Drawing.Font(M04_txt_hoTenNguoiVD.Font, FontStyle.Regular);
                M04_txt_hoTenNguoiVD.ForeColor = Color.Black;
            }

        }

        private void M04_txt_kinhGui_MouseClick(object sender, MouseEventArgs e)
        {
            if (M04_txt_kinhGui.Text == placeholder)
            {
                M04_txt_kinhGui.Clear();
                M04_txt_kinhGui.Font = new System.Drawing.Font(M04_txt_kinhGui.Font, FontStyle.Regular);
                M04_txt_kinhGui.ForeColor = Color.Black;
            }

        }

        private void M04_NSD_txt_hoTen_MouseClick(object sender, MouseEventArgs e)
        {
            M04_NSD_txt_hoTen.Clear();
            M04_NSD_txt_hoTen.Font = new System.Drawing.Font(M04_NSD_txt_hoTen.Font, FontStyle.Regular);
            M04_NSD_txt_hoTen.ForeColor = Color.Black;
        }

        private void M04_NSD_txt_diaChi_MouseClick(object sender, MouseEventArgs e)
        {
            M04_NSD_txt_diaChi.Clear();
            M04_NSD_txt_diaChi.Font = new System.Drawing.Font(M04_NSD_txt_diaChi.Font, FontStyle.Regular);
            M04_NSD_txt_diaChi.ForeColor = Color.Black;
        }

        private void M04_txt_ThuaDatDK_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_ThuaDatDK.Clear();
            M04_txt_ThuaDatDK.Font = new System.Drawing.Font(M04_txt_ThuaDatDK.Font, FontStyle.Regular);
            M04_txt_ThuaDatDK.ForeColor = Color.Black;
        }

        private void M04_txt_thuaDatSo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_thuaDatSo.Clear();
            M04_txt_thuaDatSo.Font = new System.Drawing.Font(M04_txt_thuaDatSo.Font, FontStyle.Regular);
            M04_txt_thuaDatSo.ForeColor = Color.Black;
        }

        private void M04_txt_toBanDoSo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_toBanDoSo.Clear();
            M04_txt_toBanDoSo.Font = new System.Drawing.Font(M04_txt_toBanDoSo.Font, FontStyle.Regular);
            M04_txt_toBanDoSo.ForeColor = Color.Black;
        }

        private void M04_txt_diaChiDat_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_diaChiDat.Clear();
            M04_txt_diaChiDat.Font = new System.Drawing.Font(M04_txt_diaChiDat.Font, FontStyle.Regular);
            M04_txt_diaChiDat.ForeColor = Color.Black;
        }

        private void M04_txt_dtDat_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_dtDat.Clear();
            M04_txt_dtDat.Font = new System.Drawing.Font(M04_txt_dtDat.Font, FontStyle.Regular);
            M04_txt_dtDat.ForeColor = Color.Black;
        }

        private void M04_txt_suDungChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungChung.Clear();
            M04_txt_suDungChung.Font = new System.Drawing.Font(M04_txt_suDungChung.Font, FontStyle.Regular);
            M04_txt_suDungChung.ForeColor = Color.Black;
        }

        private void M04_txt_suDungRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungRieng.Clear();
            M04_txt_suDungRieng.Font = new System.Drawing.Font(M04_txt_suDungRieng.Font, FontStyle.Regular);
            M04_txt_suDungRieng.ForeColor = Color.Black;
        }

        private void M04_txt_suDungMD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_suDungMD.Clear();
            M04_txt_suDungMD.Font = new System.Drawing.Font(M04_txt_suDungMD.Font, FontStyle.Regular);
            M04_txt_suDungMD.ForeColor = Color.Black;
        }

        private void M04_txt_nguonGocSD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_nguonGocSD.Clear();
            M04_txt_nguonGocSD.Font = new System.Drawing.Font(M04_txt_nguonGocSD.Font, FontStyle.Regular);
            M04_txt_nguonGocSD.ForeColor = Color.Black;
        }

        private void M04_txt_sdHanChe_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_sdHanChe.Clear();
            M04_txt_sdHanChe.Font = new System.Drawing.Font(M04_txt_sdHanChe.Font, FontStyle.Regular);
            M04_txt_sdHanChe.ForeColor = Color.Black;
        }

        private void M04_txt_cua_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_cua.Clear();
            M04_txt_cua.Font = new System.Drawing.Font(M04_txt_cua.Font, FontStyle.Regular);
            M04_txt_cua.ForeColor = Color.Black;
        }

        private void M04_txt_ndQuyenSD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_ndQuyenSD.Clear();
            M04_txt_ndQuyenSD.Font = new System.Drawing.Font(M04_txt_ndQuyenSD.Font, FontStyle.Regular);
            M04_txt_ndQuyenSD.ForeColor = Color.Black;
        }

        private void M04_txt_NO_loaiNhaO_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_loaiNhaO.Clear();
            M04_txt_NO_loaiNhaO.Font = new System.Drawing.Font(M04_txt_NO_loaiNhaO.Font, FontStyle.Regular);
            M04_txt_NO_loaiNhaO.ForeColor = Color.Black;
        }

        private void M04_txt_NO_dtXD_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_dtXD.Clear();
            M04_txt_NO_dtXD.Font = new System.Drawing.Font(M04_txt_NO_dtXD.Font, FontStyle.Regular);
            M04_txt_NO_dtXD.ForeColor = Color.Black;
        }

        private void M04_txt_NO_dtSan_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_dtSan.Clear();
            M04_txt_NO_dtSan.Font = new System.Drawing.Font(M04_txt_NO_dtSan.Font, FontStyle.Regular);
            M04_txt_NO_dtSan.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soHuuChung.Clear();
            M04_txt_NO_soHuuChung.Font = new System.Drawing.Font(M04_txt_NO_soHuuChung.Font, FontStyle.Regular);
            M04_txt_NO_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soHuuRieng.Clear();
            M04_txt_NO_soHuuRieng.Font = new System.Drawing.Font(M04_txt_NO_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_NO_soHuuRieng.ForeColor = Color.Black;
        }

        private void M04_txt_NO_ketCau_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_ketCau.Clear();
            M04_txt_NO_ketCau.Font = new System.Drawing.Font(M04_txt_NO_ketCau.Font, FontStyle.Regular);
            M04_txt_NO_ketCau.ForeColor = Color.Black;
        }

        private void M04_txt_NO_soTang_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_NO_soTang.Clear();
            M04_txt_NO_soTang.Font = new System.Drawing.Font(M04_txt_NO_soTang.Font, FontStyle.Regular);
            M04_txt_NO_soTang.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_loaiCay_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_loaiCay.Clear();
            M04_txt_RSX_loaiCay.Font = new System.Drawing.Font(M04_txt_RSX_loaiCay.Font, FontStyle.Regular);
            M04_txt_RSX_loaiCay.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_dienTich_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_dienTich.Clear();
            M04_txt_RSX_dienTich.Font = new System.Drawing.Font(M04_txt_RSX_dienTich.Font, FontStyle.Regular);
            M04_txt_RSX_dienTich.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_tuTrong_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_tuTrong.Clear();
            M04_txt_RSX_tuTrong.Font = new System.Drawing.Font(M04_txt_RSX_tuTrong.Font, FontStyle.Regular);
            M04_txt_RSX_tuTrong.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_NNKTT_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_NNKTT.Clear();
            M04_txt_RSX_NNKTT.Font = new System.Drawing.Font(M04_txt_RSX_NNKTT.Font, FontStyle.Regular);
            M04_txt_RSX_NNKTT.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_NNTT_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_NNTT.Clear();
            M04_txt_RSX_NNTT.Font = new System.Drawing.Font(M04_txt_RSX_NNTT.Font, FontStyle.Regular);
            M04_txt_RSX_NNTT.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_nhanChuyenQuyen_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_nhanChuyenQuyen.Clear();
            M04_txt_RSX_nhanChuyenQuyen.Font = new System.Drawing.Font(M04_txt_RSX_nhanChuyenQuyen.Font, FontStyle.Regular);
            M04_txt_RSX_nhanChuyenQuyen.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_nguonVon_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_nguonVon.Clear();
            M04_txt_RSX_nguonVon.Font = new System.Drawing.Font(M04_txt_RSX_nguonVon.Font, FontStyle.Regular);
            M04_txt_RSX_nguonVon.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_soHuuChung.Clear();
            M04_txt_RSX_soHuuChung.Font = new System.Drawing.Font(M04_txt_RSX_soHuuChung.Font, FontStyle.Regular);
            M04_txt_RSX_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_RSX_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_RSX_soHuuRieng.Clear();
            M04_txt_RSX_soHuuRieng.Font = new System.Drawing.Font(M04_txt_RSX_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_RSX_soHuuRieng.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_loaicay_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_loaicay.Clear();
            M04_txt_CLN_loaicay.Font = new System.Drawing.Font(M04_txt_CLN_loaicay.Font, FontStyle.Regular);
            M04_txt_CLN_loaicay.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_dt_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_dt.Clear();
            M04_txt_CLN_dt.Font = new System.Drawing.Font(M04_txt_CLN_dt.Font, FontStyle.Regular);
            M04_txt_CLN_dt.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_soHuuChung_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_soHuuChung.Clear();
            M04_txt_CLN_soHuuChung.Font = new System.Drawing.Font(M04_txt_CLN_soHuuChung.Font, FontStyle.Regular);
            M04_txt_CLN_soHuuChung.ForeColor = Color.Black;
        }

        private void M04_txt_CLN_soHuuRieng_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_CLN_soHuuRieng.Clear();
            M04_txt_CLN_soHuuRieng.Font = new System.Drawing.Font(M04_txt_CLN_soHuuRieng.Font, FontStyle.Regular);
            M04_txt_CLN_soHuuRieng.ForeColor = Color.Black;
        }

        private void Mau04_txt_giayTokemTheo_MouseClick(object sender, MouseEventArgs e)
        {
            Mau04_txt_giayTokemTheo.Clear();
            Mau04_txt_giayTokemTheo.Font = new System.Drawing.Font(Mau04_txt_giayTokemTheo.Font, FontStyle.Regular);
            Mau04_txt_giayTokemTheo.ForeColor = Color.Black;
        }

        private void M04_txt_nhuCauGhiNo_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_nhuCauGhiNo.Clear();
            M04_txt_nhuCauGhiNo.Font = new System.Drawing.Font(M04_txt_nhuCauGhiNo.Font, FontStyle.Regular);
            M04_txt_nhuCauGhiNo.ForeColor = Color.Black;
        }

        private void M04_txt_deNghiKhac_MouseClick(object sender, MouseEventArgs e)
        {
            M04_txt_deNghiKhac.Clear();
            M04_txt_deNghiKhac.Font = new System.Drawing.Font(M04_txt_deNghiKhac.Font, FontStyle.Regular);
            M04_txt_deNghiKhac.ForeColor = Color.Black;
        }

        private void M04_btn_Luu_Click(object sender, EventArgs e)
        {
            lstTxt = new List<TextBox>();
            lstTxt.Add(M04_NSD_txt_diaChi);
            lstTxt.Add(M04_NSD_txt_hoTen);
            lstTxt.Add(M04_NSD_txt_so);
            lstTxt.Add(M04_txt_cua);
            lstTxt.Add(M04_txt_diaChiDat);
            lstTxt.Add(M04_txt_dtDat);
            lstTxt.Add(M04_txt_hoTenNguoiVD);
            lstTxt.Add(M04_txt_kinhGui);
            lstTxt.Add(M04_txt_ndQuyenSD);
            lstTxt.Add(M04_txt_nguonGocSD);
            lstTxt.Add(M04_txt_nhuCauGhiNo);
            lstTxt.Add(M04_txt_quyenSo);
            lstTxt.Add(M04_txt_sdHanChe);
            lstTxt.Add(M04_txt_suDungChung);
            lstTxt.Add(M04_txt_suDungMD);
            lstTxt.Add(M04_txt_suDungRieng);
            lstTxt.Add(M04_txt_ThuaDatDK);
            lstTxt.Add(M04_txt_thuaDatSo);
            lstTxt.Add(M04_txt_toBanDoSo);


            List<TextBox> lstTxt2 = new List<TextBox>();
           
            lstTxt2.Add(M04_txt_CLN_loaicay);
            lstTxt2.Add(M04_txt_CLN_soHuuChung);
            lstTxt2.Add(M04_txt_CLN_soHuuRieng);
            lstTxt2.Add(M04_txt_NO_dtSan);
            lstTxt2.Add(M04_txt_NO_dtXD);
            lstTxt2.Add(M04_txt_NO_ketCau);
            lstTxt2.Add(M04_txt_NO_loaiNhaO);
            lstTxt2.Add(M04_txt_NO_soHuuChung);
            lstTxt2.Add(M04_txt_NO_soHuuRieng);
            lstTxt2.Add(M04_txt_NO_soTang);
            lstTxt2.Add(M04_txt_RSX_dienTich);
            lstTxt2.Add(M04_txt_RSX_loaiCay);
            lstTxt2.Add(M04_txt_RSX_nguonVon);
            lstTxt2.Add(M04_txt_RSX_nhanChuyenQuyen);
            lstTxt2.Add(M04_txt_RSX_NNKTT);
            lstTxt2.Add(M04_txt_RSX_NNTT);
            lstTxt2.Add(M04_txt_RSX_soHuuChung);
            lstTxt2.Add(M04_txt_RSX_soHuuRieng);
            lstTxt2.Add(M04_txt_RSX_tuTrong);
            lstTxt2.Add(M04_txt_NO_thsd);
            lstTxt2.Add(M04_txt_CLN_thsd);
            lstTxt2.Add(M04_txt_RSX_thsd);


            lstTxt2.Add(M04_txt_CLN_dt);
            for (int i = 0; i < lstTxt.Count; i++)
            {

                if (string.IsNullOrEmpty(lstTxt[i].Text) || lstTxt[i].Text == placeholder)
                {
                    MessageBox.Show("Phải điền đấy đầy đủ thông tin!");
                    return;
                }
            }
            for (int j = 0; j < lstTxt2.Count; j++)
            {

                if (lstTxt2[j].Text == "" || lstTxt2[j].Text == placeholder)
                {
                    lstTxt2[j].Text = 0.ToString();
                }
            }

            BIEUMAU_M04 _bm = new BIEUMAU_M04();
            _bm.DENGHIKHAC = M04_txt_deNghiKhac.Text;
            _bm.DIACHI_NVD = M04_NSD_txt_diaChi.Text;
            _bm.DIACHI_THUADAT = M04_txt_diaChiDat.Text;
            _bm.DTSAN_NO = float.Parse(M04_txt_NO_dtSan.Text);
            _bm.DTXAYDUNG_NO = float.Parse(M04_txt_NO_dtXD.Text);
            _bm.DT_CLN = float.Parse(M04_txt_CLN_dt.Text);
            _bm.DT_RSX = float.Parse(M04_txt_RSX_dienTich.Text);
            _bm.DT_TD = float.Parse(M04_txt_dtDat.Text);
            _bm.GIAYTOKEMTHEO = Mau04_txt_giayTokemTheo.Text;
            _bm.HOTEN_NVD = M04_NSD_txt_hoTen.Text;
            _bm.ID_LOAIBIEUMAU = 4;
            _bm.KETCAU_NO = M04_txt_NO_ketCau.Text;
            _bm.KINHGUI = M04_txt_kinhGui.Text;
            _bm.CUA_TD = M04_txt_cua.Text;
            _bm.QUYENSUDUNGHANCHESO = int.Parse(M04_txt_sdHanChe.Text);
            _bm.NDQUYENSD_TD = M04_txt_ndQuyenSD.Text;
            _bm.LOAICAY_CLN = M04_txt_CLN_loaicay.Text;
            _bm.LOAICAY_RSX = M04_txt_RSX_loaiCay.Text;
            _bm.LOAINHAO_NO = M04_txt_NO_loaiNhaO.Text;
            _bm.TUTHOIDIEM_TD = DateTime.Parse(M04_dtp_tuThoiDiem.Value.ToString("MM/dd/yyyy"));
            _bm.NGAYVIETDON = DateTime.Parse(M04_dtp_NgayVD.Value.ToString("MM/dd/yyyy"));
            _bm.NHU_CAU_GHI_NO = M04_txt_nhuCauGhiNo.Text;
            _bm.QUYENSO = int.Parse(M04_txt_quyenSo.Text);
            _bm.SDCHUNG_RSX = float.Parse(M04_txt_RSX_soHuuChung.Text);
            _bm.SDRIENG_RSX = float.Parse(M04_txt_RSX_soHuuRieng.Text);
            _bm.SHCHUNG_CLN = float.Parse(M04_txt_CLN_soHuuChung.Text);
            _bm.SHCHUNG_NO = float.Parse(M04_txt_NO_soHuuChung.Text);
            _bm.SHRIENG_TD = float.Parse(M04_txt_NO_soHuuRieng.Text);
            _bm.SO = M04_NSD_txt_so.Text;
            _bm.SOTANG_NO = int.Parse(M04_txt_NO_soTang.Text);
            _bm.THOIHANDENGHISD_TD = M04_txt_tgdenghiSDD.Text;
            _bm.THOIHANSDDEN_CLN = M04_txt_CLN_thsd.Text;
            _bm.THOIHANSDDEN_NO = M04_txt_NO_thsd.Text;
            _bm.THOIHANSDDEN_RSX = M04_txt_RSX_thsd.Text;
            _bm.THUADATDANGKY = M04_txt_ThuaDatDK.Text;
            _bm.THUADATSO = int.Parse(M04_txt_thuaDatSo.Text);
            _bm.TOBANDOSO = M04_txt_toBanDoSo.Text;
            _bm.TT_XOA = false;
            _bm.TT_XUAT = false;
            _bm.MUCDICHSD = M04_txt_suDungMD.Text;
            if (dal.saveInfo_M04(_bm))
            {
                
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lưu thất bại, vui lòng thử lại!");
            }
           
        }
        public bool xuatFiles()
        {
            List<BIEUMAU_M04> lstbm = dal.loadInfo_m04().ToList();


            //Model_MauSo04 mbm = new Model_MauSo04();
            //MessageBox.Show(mbm.DENGHIKHAC.ToString());
            foreach (var item in lstbm)
            {
                
                var KinhGui = item.KINHGUI;
                var So = item.SO;
                var QuyenSo = item.QUYENSO;
                var HoTen_NV = item.HOTEN_NVD;
                var DiaChi = item.DIACHI_NVD;
                var ThuaDatSo = item.THUADATSO;
                var ToBanDoSo = item.TOBANDOSO;
                var DiaChiThuaDat = item.DIACHI_THUADAT;
                var DienTich_TD = item.DT_TD;
                var SDChung = item.SHCHUNG_TD;
                var SDRieng = item.SHRIENG_TD;
                var SDMD = item.MUCDICHSD;
                var TuThoiDiem = item.TUTHOIDIEM_TD;
                var THDNSD = item.THOIHANDENGHISD_TD;
                var LoaiNhaO="";
                var DTNhaO = "";
                var DTSan = "";
                var NOSDChung = "";
                var NOSDRieng = "";
                var NOKetCau = "";
                var NOSoTang = "";
                var NOThoiHanSH = "";
                var RXSLoaiCay = "";
                var RXSDienTich = "";
                var CLNLoaiCay = "";
                var RXSSHChung = "";
                var RXSSHRieng = "";
                var RXSThoiGianSH = "";
                var CLNDienTich = "";
                var CLNSHChung = "";
                var CLNSHRieng = "";
                var CLNThoiGianSH = "";

                if (item.LOAINHAO_NO != null)
                {
                    LoaiNhaO = item.LOAINHAO_NO;//
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



                var GiayToKemTheo = item.GIAYTOKEMTHEO;
                var NhuCauGhiNo = item.NHU_CAU_GHI_NO;
                var DeNghiKhac = item.DENGHIKHAC;

                var NgayV = "";
                if (item.NGAYVIETDON.Value.Day > 10)
                {
                    NgayV = item.NGAYVIETDON.Value.Day.ToString();
                }
                else { NgayV = "0" + item.NGAYVIETDON.Value.Day; }

                var ThangV = "";
                if (item.NGAYVIETDON.Value.Month > 10)
                {
                    ThangV = item.NGAYVIETDON.Value.Month.ToString();
                }
                else {
                    ThangV = "0" + item.NGAYVIETDON.Value.Month;
                }

                var NamV = item.NGAYVIETDON.Value.Year;


                //CultureInfo cul = new CultureInfo.GetCultureInfo("vi-VN");
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var wordDoc = wordApp.Documents.OpenNoRepairDialog(path);

                ReplaceWord("{KinhGui}", KinhGui, wordDoc);
                ReplaceWord("{So}", So, wordDoc);
                ReplaceWord("{QuyenSo}", QuyenSo.ToString(), wordDoc);
                ReplaceWord("{HoTen_NV}", HoTen_NV.ToUpper(), wordDoc);
                ReplaceWord("{DiaChi}", DiaChi, wordDoc);
                ReplaceWord("{ThuaDatSo}", ThuaDatSo.ToString(), wordDoc);
                ReplaceWord("{ToBanDoSo}", ToBanDoSo, wordDoc);
                ReplaceWord("{DiaChiThuaDat}", DiaChiThuaDat, wordDoc);
                ReplaceWord("{DienTich_TD}", DienTich_TD.ToString(), wordDoc);
                ReplaceWord("{SDChung}", SDChung.ToString(), wordDoc);
                ReplaceWord("{SDRieng}", SDRieng.ToString(), wordDoc);
                ReplaceWord("{SDMD}", SDMD, wordDoc);
                ReplaceWord("{TuThoiDiem}", TuThoiDiem.ToString(), wordDoc);
                ReplaceWord("{LoaiNhaO}", LoaiNhaO, wordDoc);
                ReplaceWord("{DTNhaO}", DTNhaO.ToString(), wordDoc);
                ReplaceWord("{DTSan}", DTSan.ToString(), wordDoc);
                ReplaceWord("{NOSDChung}", NOSDChung.ToString(), wordDoc);
                ReplaceWord("{NOSDRieng}", NOSDRieng.ToString(), wordDoc);
                ReplaceWord("{NOKetCau}", NOKetCau, wordDoc);
                ReplaceWord("{NOSoTang}", NOSoTang.ToString(), wordDoc);
                ReplaceWord("{NOThoiHanSH}", NOThoiHanSH, wordDoc);
                ReplaceWord("{RXSLoaiCay}", RXSLoaiCay, wordDoc);
                ReplaceWord("{RXSDienTich}", RXSDienTich.ToString(), wordDoc);
                ReplaceWord("{CLNLoaiCay}", CLNLoaiCay, wordDoc);
                ReplaceWord("{RXSSHChung}", RXSSHChung.ToString(), wordDoc);
                ReplaceWord("{RXSSHRieng}", RXSSHRieng.ToString(), wordDoc);
                ReplaceWord("{RXSThoiGianSH}", RXSThoiGianSH, wordDoc);
                ReplaceWord("{CLNDienTich}", CLNDienTich.ToString(), wordDoc);
                ReplaceWord("{CLNSHChung}", CLNSHChung.ToString(), wordDoc);
                ReplaceWord("{CLNSHRieng}", CLNSHRieng.ToString(), wordDoc);
                ReplaceWord("{CLNThoiGianSH}", CLNThoiGianSH, wordDoc);
                ReplaceWord("{GiayToKemTheo}", GiayToKemTheo, wordDoc);
                ReplaceWord("{NhuCauGhiNo}", NhuCauGhiNo, wordDoc);
                ReplaceWord("{DeNghiKhac}", DeNghiKhac, wordDoc);
                ReplaceWord("{NgayV}", NgayV.ToString(), wordDoc);
                ReplaceWord("{ThangV}", ThangV.ToString(), wordDoc);
                ReplaceWord("{NamV}", NamV.ToString(), wordDoc);
                string pathOut = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Mau04DK"+ So + ".docx";
                wordDoc.SaveAs2(pathOut);
                
                wordApp.Documents.OpenNoRepairDialog(pathOut);
                return true;
            }
            return false;
        }

        public void ReplaceWord(string str, string text, Microsoft.Office.Interop.Word.Document wdc)
        {
            var rag = wdc.Content;
            rag.Find.ClearFormatting();
            rag.Find.Execute(FindText: str, ReplaceWith: text);
        }
    }
}
