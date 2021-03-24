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
    public partial class UCDetailedRecipe : UserControl
    {

        public string recipeId { get; set; }
        public UCDetailedRecipe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = recipeId;
        }
    }
}
