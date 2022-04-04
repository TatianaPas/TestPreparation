using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPreparation.Models.DB;

namespace TestPreparation.Models
{
    internal class DAO
    {
        public static void addCustomer(Tcustomer cust)
        {
            using(DAD_TatianaContext ctx = new DAD_TatianaContext())
            {
                
                    ctx.Tcustomers.Add(cust);
                    ctx.SaveChanges();
  
            }
        }
         
        
    }
}
