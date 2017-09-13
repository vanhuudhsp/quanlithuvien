using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QLTHUVIEN.LOP
{
    class XL_MUONSACH:XL_BANG 
    {
         #region Các hàm khởi tạo
        public XL_MUONSACH():base("MUONSACH"){}
        public XL_MUONSACH(string pChuoi_SQL):base("MUONSACH", pChuoi_SQL) {}
        #endregion
        #region Các hàm xử lý sự kiện
        public void Tim(DataRow p_Dong_dieu_kien)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (p_Dong_dieu_kien["MaThe"] !=null )
                mang_DK.Add("MaThe LIKE '*"+ p_Dong_dieu_kien["MaThe"] + "*'"); 
            if (p_Dong_dieu_kien["MaSach"] !=null )
                mang_DK.Add("MaSach LIKE '*"+ p_Dong_dieu_kien["MaSach"] + "*'");
            if (p_Dong_dieu_kien["NgayMuon"] != null)
                mang_DK.Add("NgayMuon = #" + p_Dong_dieu_kien["NgayMuon"] + "#");
            if (p_Dong_dieu_kien["NgayTra"] != null)
                mang_DK.Add("NgayTra = #" + p_Dong_dieu_kien["NgayTra"] + "#");
            
            if (mang_DK.Count >0)
            {
                for(int i =0; i<mang_DK.Count; i++)
                    if (i == 0) chuoi_DK = mang_DK[i].ToString();
                    else chuoi_DK += " AND " + mang_DK[i];
            }
            Loc_du_lieu(chuoi_DK);
        }
        #endregion
    }
}
