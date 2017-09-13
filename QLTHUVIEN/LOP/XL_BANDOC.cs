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
    class XL_BANDOC: XL_BANG 
    {
        #region Các hàm khởi tạo
        public XL_BANDOC():base("BANDOC"){}
        public XL_BANDOC(string pChuoi_SQL):base("BANDOC", pChuoi_SQL) {}
        #endregion
        #region Các hàm xử lý sự kiện
        public void Tim(DataRow p_Dong_dieu_kien)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (p_Dong_dieu_kien["MaThe"] !=null )
                mang_DK.Add("MaThe LIKE '*"+ p_Dong_dieu_kien["MaThe"] + "*'"); 
            if (p_Dong_dieu_kien["TenBanDoc"] !=null )
                mang_DK.Add("TenBanDoc LIKE '*"+ p_Dong_dieu_kien["TenBanDoc"] + "*'");
            if (p_Dong_dieu_kien["DiaChi"] != null)
                mang_DK.Add("DiaChi LIKE '*" + p_Dong_dieu_kien["DiaChi"] + "*'");
            if (p_Dong_dieu_kien["SoDT"] != null)
                mang_DK.Add("SoDT LIKE '*" + p_Dong_dieu_kien["SoDT"] + "*'");
            
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
