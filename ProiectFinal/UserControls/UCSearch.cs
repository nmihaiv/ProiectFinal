using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProiectFinal.Api;
using ProiectFinal.Model;

namespace ProiectFinal.UserControls
{
    public partial class UCSearch : UserControl
    {

        
        public UCSearch()
        {
            InitializeComponent();
            
            
        }

        public string FormatText(string text)
        {
            text = Regex.Replace(text, @"<a\b[^>]+>([^<]*(?:(?!</a)<[^<]*)*)</a>", "$1");
            text = Regex.Replace(text, "<.*?>", "");

            return text;
        }

        public async void searchButton_Click(object sender, EventArgs e)
        {
            SearchRecipe recipe = new SearchRecipe();

            var recipes = await recipe.CallApiAsync(textBox1.Text);
            List<Recipe> output = JsonConvert.DeserializeObject<List<Recipe>>(recipes);

            foreach (var test in output)
            {
                test.setImageFromUrl();
            }

            dataGridView1.DataSource = output;
            dataGridView1.Columns["image"].Visible = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UCDetailedRecipe detailedRecipe = new UCDetailedRecipe();
            detailedRecipe.recipeId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Helper.Helper.changeContent(detailedRecipe, "ucDetailedRecipe");
        }
    }
}
