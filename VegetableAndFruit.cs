using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOnWPF
{
    public class VegetableAndFruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public decimal Calories { get; set; }


        public VegetableAndFruit(string Name, string Type, string Color, decimal Calories)
        {
            this.Name = Name;
            this.Type = Type;
            this.Color= Color;
            this.Calories=Calories;
        }

    }
}
