using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.DAO
{
    class CountDAO
    {
        private LMSEntities context = new LMSEntities();

        public COUNT getCountByBook(int bookId)
        {
            return context.COUNTs.Where(c => c.BOOK_ID == bookId).FirstOrDefault();
        }

        public List<COUNT> getAllCount()
        {
            return context.COUNTs.ToList<COUNT>();
        }
        public void addCount(COUNT Count)
        {
            context.COUNTs.Add(Count);
            context.SaveChanges();
        }

        public void updateCount(COUNT Count)
        {
            COUNT c = context.COUNTs.SingleOrDefault(sc => sc.BOOK_ID == Count.BOOK_ID);
            if( c != null)
            {
                c.CURRENT_COUNT = Count.CURRENT_COUNT;
                c.TOTAL_COUNT = Count.TOTAL_COUNT;
                context.SaveChanges();
            }
        }
    }
}
