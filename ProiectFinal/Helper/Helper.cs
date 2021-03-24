using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal.Helper
{
    class Helper
    {

        public static void changeContent(UserControl control, string key)
        {
            if (Form1.Instance.ContentPanel.Controls.ContainsKey(key))
            {
                Form1.Instance.ContentPanel.Controls[key].BringToFront();
            }
            else
            {
                control.Dock = DockStyle.Fill;
                control.Name = key;
                Form1.Instance.ContentPanel.Controls.Add(control);
                Form1.Instance.ContentPanel.Controls[key].BringToFront();
            }
        }

    }
}
