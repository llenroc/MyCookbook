﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookbook
{
    public class IngredientDetail
    {
        public string Name { get; set; }
        public string Quantity { get; set; }

        private List<string> _units = new List<string> {"cup", "tbsps", "tsp",
                                                       "quart", "oz", "gal", "unit"};
        public List<string> Units
        {
            get
            {
                return _units;
            }
        }

        public string SelectedUnit { get; set; }
    }
}
