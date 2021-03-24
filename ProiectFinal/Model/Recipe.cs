using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFinal.Model
{
    public class Recipe
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public int usedIngredientCount { get; set; }
        public int missedIngredientCount { get; set; }
        public List<MissedIngredient> missedIngredients { get; set; }
        public List<UsedIngredient> usedIngredients { get; set; }
        public int likes { get; set; }
        public Image imageFromUrl { get; set; }

        public async void setImageFromUrl()
        {
            if (this.image == null)
            {
                return;
            }
            else
            {           
                var request = WebRequest.Create(this.image);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    this.imageFromUrl = Bitmap.FromStream(stream);
                }
            }
        }
    }
}
