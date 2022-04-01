using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utils
{
    class FineUtils
    {
        public int calculateDaysExceeded(DateTime ExpiryDate)
        {
            TimeSpan days = DateTime.Now - ExpiryDate;
            return days.Days;
        }

        public decimal calculateTotalFine(int days)
        {
            if(days > 0)
            {
                if(days <= 5)
                {
                    return Convert.ToDecimal(days * 0.5);
                }else if(days > 5 && days <= 10){
                    return Convert.ToDecimal((5 * 0.5) + (days - 5) * 1);
                }
                else
                {
                    return Convert.ToDecimal((5 * 0.5) + (5 * 1) + (days - 10) * 1.5);
                }
            }
            return 0;
        }
    }
}
