using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCKDS.Model
{
    public class OrderLines
    {
        public string OrderType { get; set; }
        public int Qty { get; set; }
        public string Items { get; set; }
        public int OrderStatusID { get; set; }
        public string OrderState { get; set; }
    }
}
