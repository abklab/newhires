using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHApp.Models

{
    public class DriversLicense
    {
        public int ID { get; set; }
        public int? AppID { get; set; }
        public string DL_Number { get; set; }
        public string DL_State { get; set; }
        public string DL_Type { get; set; }
        public DateTime DL_ExpirationDate { get; set; }
        public string Notes { get; set; }

      
    }
}
