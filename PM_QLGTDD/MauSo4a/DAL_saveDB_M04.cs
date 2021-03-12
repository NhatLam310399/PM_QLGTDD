using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLGTDD.MauSo4a
{
    public class DAL_saveDB_M04
    {
        DB_QLGTDDDataContext db = new DB_QLGTDDDataContext();
        public bool saveInfo_M04(BIEUMAU_M04 bm)
        {
            BIEUMAU_M04 _bm = new BIEUMAU_M04();

            try
            {

                if (bm.DTSAN_NO != 0)
                {
                    _bm.DTSAN_NO = bm.DTSAN_NO;
                }
                if (bm.DTXAYDUNG_NO != 0)
                {
                    _bm.DTXAYDUNG_NO = bm.DTXAYDUNG_NO;
                }
                if (bm.DT_CLN != 0)
                {
                   _bm.DT_CLN = bm.DT_CLN;
                }
                if (bm.DT_RSX != 0)
                {
                    _bm.DT_RSX = bm.DT_RSX;
                }
               
                if (bm.SDCHUNG_RSX != 0)
                {
                    _bm.SDCHUNG_RSX = bm.SDCHUNG_RSX;
                }
                if (bm.SDRIENG_RSX != 0)
                {
                    _bm.SDRIENG_RSX = bm.SDRIENG_RSX;
                }
                if (bm.SHCHUNG_CLN != 0)
                {
                    _bm.SHCHUNG_CLN = bm.SHCHUNG_CLN;
                }
                if (bm.SHCHUNG_NO != 0)
                {
                    _bm.SHCHUNG_NO = bm.SHCHUNG_NO;
                }
                if (bm.SHRIENG_NO != 0)
                {
                    _bm.SHRIENG_NO = bm.SHRIENG_NO;
                }
                if (bm.THOIHANSDDEN_CLN != "0")
                {
                    _bm.THOIHANSDDEN_CLN = bm.THOIHANSDDEN_CLN;
                }
                if (bm.THOIHANSDDEN_NO != "0")
                {
                    _bm.THOIHANSDDEN_NO = bm.THOIHANSDDEN_NO;
                }
                if (bm.THOIHANSDDEN_RSX != "0")
                {
                    _bm.THOIHANSDDEN_RSX = bm.THOIHANSDDEN_RSX;
                }
                if (bm.KETCAU_NO != "0")
                {
                    _bm.KETCAU_NO = bm.KETCAU_NO;
                }
                if (bm.LOAICAY_CLN != "0")
                {
                    _bm.LOAICAY_CLN = bm.LOAICAY_CLN;
                }
                if (bm.LOAICAY_RSX != "0")
                {
                    _bm.LOAICAY_RSX = bm.LOAICAY_RSX;
                }
                if (bm.LOAINHAO_NO != "0")
                {
                    _bm.LOAINHAO_NO = bm.LOAINHAO_NO;
                }
                if (bm.SOTANG_NO != 0)
                {
                    _bm.SOTANG_NO = bm.SOTANG_NO;
                }
                _bm.DT_TD = bm.DT_TD;
                _bm.SHRIENG_TD = bm.SHRIENG_TD;
                _bm.SHCHUNG_TD = bm.SHCHUNG_TD;
                _bm.DENGHIKHAC = bm.DENGHIKHAC;
                _bm.DIACHI_NVD = bm.DIACHI_NVD;
                _bm.DIACHI_THUADAT = bm.DIACHI_THUADAT;
                _bm.GIAYTOKEMTHEO = bm.GIAYTOKEMTHEO;
                _bm.HOTEN_NVD = bm.HOTEN_NVD;
                _bm.ID_LOAIBIEUMAU = bm.ID_LOAIBIEUMAU;
                _bm.KINHGUI = bm.KINHGUI;
                _bm.NGAYVIETDON = bm.NGAYVIETDON;
                _bm.NHU_CAU_GHI_NO = bm.NHU_CAU_GHI_NO;
                _bm.QUYENSO = bm.QUYENSO;
                _bm.SO = bm.SO;
                _bm.THOIHANDENGHISD_TD = bm.THOIHANDENGHISD_TD;
   
                _bm.THUADATSO = bm.THUADATSO;
                _bm.TOBANDOSO = bm.TOBANDOSO;
                _bm.TT_XOA = bm.TT_XOA;
                _bm.TT_XUAT = bm.TT_XUAT;
                _bm.MUCDICHSD = bm.MUCDICHSD;
                _bm.TUTHOIDIEM_TD = bm.TUTHOIDIEM_TD;
                _bm.NGUONGOC_TD = bm.NGUONGOC_TD;
                _bm.QUYENSUDUNGHANCHESO = bm.QUYENSUDUNGHANCHESO;
                _bm.CUA_TD = bm.CUA_TD;
                _bm.NDQUYENSD_TD = bm.NDQUYENSD_TD;
                db.BIEUMAU_M04s.InsertOnSubmit(_bm);
                db.SubmitChanges();
                return true;


            }
            catch (Exception e) {
                return false;
            }
        }
        public bool editInfo_m04(BIEUMAU_M04 bm)
        {
            BIEUMAU_M04 _bm = db.BIEUMAU_M04s.OrderByDescending(i => i.ID).First();
            if (_bm != null)
            {
                try
                {
                    _bm = bm;
                    return true;
                }
                catch (Exception e) { return false; }


            }
            return false;
        }
        public List<BIEUMAU_M04> loadInfo_m04()
        {

            var bm = (from m in db.BIEUMAU_M04s
                     
                      where m.TT_XOA == false
                      select m).OrderByDescending(i=>i.ID).Take(1).ToList();
            return bm;
            
        }
        
        public bool del(BIEUMAU_M04 bm)
        {
            BIEUMAU_M04 _bm = db.BIEUMAU_M04s.Where(m => m.ID == bm.ID).FirstOrDefault();
            if (_bm != null)
            {
                _bm.TT_XOA = true;
                return true;
            }
            return false;
        }
        
    }
}
