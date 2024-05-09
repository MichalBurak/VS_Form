using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Enums;

namespace test.Entity
{
    public class Product
    {

        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public ProductUnitEnum unit { get; set; }
        public float weight { get; set; }
        public bool invoice { get; set; }
        public decimal quantity { get; set; }
        public bool activity { get; set; }
        public string countries { get; set; }
        public DateTime date { get; set; }



    }
}
