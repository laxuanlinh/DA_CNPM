using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCNPM.Controllers;
using DoAnCNPM.Shareds;

namespace DoAnCNPM.Views
{
    public partial class frm_capnhat_docgia : Form
    {
        public frm_capnhat_docgia()
        {
            InitializeComponent();
        }

        docgia_ctrl docgia = new docgia_ctrl();

        private void frm_capnhat_docgia_Load(object sender, EventArgs e)
        {
            var dt = docgia.select_all_docgia();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    MessageBox.Show(dt.errInfor);
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.fail:
                    if (Utils.switch_false())
                    {
                        MessageBox.Show(dt.errInfor);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }
    }
}
