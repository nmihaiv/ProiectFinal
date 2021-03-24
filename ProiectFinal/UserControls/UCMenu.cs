using ProiectFinal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProiectFinal.UserControls
{
    public partial class UCMenu : UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Are you sure you wish to exit the application?", "Do you wish to quit?", MessageBoxButtons.YesNo);
            if(option == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UCHome home = new UCHome();
            Helper.Helper.changeContent(home, "ucHome");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UCSearch search = new UCSearch();
            Helper.Helper.changeContent(search, "ucSearch");
            
        }
    }
}
