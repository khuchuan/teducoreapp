using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Entities
{
  public  class BillDetail
    {
        public int BillID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
