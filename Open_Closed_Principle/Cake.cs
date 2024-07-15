using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    internal class Cake : IRecepie
    {
        public string Ingredients { get; set; }
        public string Baking { get; set; }

        public string GetIngredients() 
        {
            return Ingredients + Baking;
        }
    }
}
