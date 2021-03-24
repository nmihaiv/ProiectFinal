using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ProiectFinal.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProiectFinal.Api
{
    public class SearchRecipe
    {
        
        private string endpoint = "https://api.spoonacular.com/";
        private string key = "2d36542fdee94056bdf7451332b65024";
        

        public async Task<string> CallApiAsync(string ingredients)
        {
            //https://api.spoonacular.com/recipes/findByIngredients?apiKey=2d36542fdee94056bdf7451332b65024&ingredients=venison,+onion&number=3
            string[] ingredientlist = ingredients.Split(',');
            string requesturi = "https://api.spoonacular.com/recipes/findByIngredients?apiKey=2d36542fdee94056bdf7451332b65024&ingredients=";
            //&ingredients=apples,+flour,+sugar&number=10

            for (int i = 0; i < ingredientlist.Length; i++)
            {
                if(i == 0)
                {
                    requesturi += ingredientlist[i];
                }
                else if(i == ingredientlist.Length-1)
                { 
                    requesturi += ",+" + ingredientlist[i] + "&number=10";
                }
                else
                {
                    requesturi += ",+" + ingredientlist[i];
                }
            }

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(requesturi))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}
