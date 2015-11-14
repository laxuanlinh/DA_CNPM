using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM.Shareds
{
    class Utils
    {
        #region "dialog"
        public static bool switch_false()
        {
            return MessageBox.Show(Constants.error, Constants.warning_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        public static bool confirm_delete()
        {
            return MessageBox.Show(Constants.confirm_delete, Constants.warning_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        public static bool confirm_exit()
        {
            return MessageBox.Show(Constants.confirm_exit, Constants.warning_caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        #endregion
    }
}
