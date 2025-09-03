using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InkRoomListGeneralCLS
    {
        public int IdStock { get; set; }
        public int Idproduct { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        //public string Status { get; set; }
        public string UNIT { get; set; }
        public int STOCK_QUANTITY { get; set; }
        public int USE_QUANTITY { get; set; }
        public string PERCENTAGE_USED { get; set; }
        public int TOTAL_STOCK_QUANTITY { get; set; }
        public int TOTAL_USE_QUANTITY { get; set; }
    }


}
