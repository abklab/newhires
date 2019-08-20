using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utility
{
    
    // Geneate Applicatin ID
      
    public class GenerateID
    {
        public string GetID { get; }


        public GenerateID(string prefix,string last4)
        {
            if (string.IsNullOrWhiteSpace(prefix) || string.IsNullOrWhiteSpace(last4))
                GetID= "";
            else
            {
                var dateString = DateTime.Today.ToString("yyyyMMdd");
                var timeString = DateTime.Now.ToString("HHmmss");
                GetID = $"{prefix}-{dateString}-{timeString}-{last4}";
            }
        }

        //public   string GenerateApplicationID()
        //{
        //    if (string.IsNullOrWhiteSpace(_prefix) || string.IsNullOrWhiteSpace(_last4))
        //        return "";
        //    else
        //    {
        //        var dateString = DateTime.Today.ToString("yyyyMMdd");
        //        var timeString = DateTime.Now.ToString("HHmmss");
        //        return $"{_prefix}-{dateString}-{timeString}-{_last4}";
        //    }
               
        //}

    }
}
