using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrarian.UI.Common
{
    class Utils
    {
        public static void NotImplementedAlert()
        {
            MessageBox.Show("Not implemented!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
