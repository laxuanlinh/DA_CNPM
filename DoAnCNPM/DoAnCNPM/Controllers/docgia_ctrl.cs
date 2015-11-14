using DoAnCNPM.Models;
using DoAnCNPM.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Controllers
{
    public class docgia_ctrl
    {
        public docgia_ctrl() { }

        QL_Thu_VienDataContext db = new QL_Thu_VienDataContext();

        public Result<List<docgia_ett>>  select_all_docgia()
        {
            Result<List<docgia_ett>> rs = new Result<List<docgia_ett>>();
            try
            {
                List<docgia_ett> lst = new List<docgia_ett>();
                var dt = db.tbl_docgias;
                if (dt.Count() > 0)
                {
                    foreach (tbl_docgia item in dt)
                    {
                        docgia_ett temp = new docgia_ett(item);
                        lst.Add(temp);
                    }
                    rs.data = lst;
                    rs.errcode = ErrorCode.sucess;
                }
                else
                {
                    rs.data = null;
                    rs.errInfor = Constants.empty_data;
                }
                return rs;
            }
            catch (Exception e)
            {
                rs.data = null;
                rs.errInfor = e.ToString();
                rs.errcode = ErrorCode.fail;
                return rs;
            }
        }
    }
}
