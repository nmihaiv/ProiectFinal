using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFinal.Model
{
    public class UsedIngredient
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
        public string aisle { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public List<string> metaInformation { get; set; }
        public List<string> meta { get; set; }
        public string image { get; set; }
    }
}
