using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Entity;
namespace LibraryManagementSystem.Service
{
    class CountService
    {
        private CountDAO CountDAO = new CountDAO();
        private COUNT Count = null;

        public int getCurrentCount(int BookId)
        {
            Count = CountDAO.getCountByBook(BookId);
            return Count.CURRENT_COUNT;
        }

        public int getTotalCount(int BookId)
        {
            Count = CountDAO.getCountByBook(BookId);
            return Count.TOTAL_COUNT;
        }

        public void addCount(int BookId, int TotalCount)
        {
            COUNT c = new COUNT();
            c.BOOK_ID = BookId;
            c.CURRENT_COUNT = TotalCount;
            c.TOTAL_COUNT = TotalCount;

            List<COUNT> Counts = CountDAO.getAllCount();
            c.ID = !Counts.Any() ? 101 : Counts.Last().ID + 1;

            CountDAO.addCount(c);
        }

        public void updateCurrentCount(int BookId, int CurrentCount)
        {
            COUNT c = new COUNT();
            c.BOOK_ID = BookId;
            c.CURRENT_COUNT = CurrentCount;
            c.TOTAL_COUNT = this.getTotalCount(BookId);
            CountDAO.updateCount(c);
        }

        public void updateTotalCount(int BookId, int TotalCount)
        {
            COUNT c = new COUNT();
            c.BOOK_ID = BookId;
            if(this.getTotalCount(BookId) != TotalCount)
            {
                c.CURRENT_COUNT = TotalCount - (this.getTotalCount(BookId) - this.getCurrentCount(BookId));
                c.TOTAL_COUNT = TotalCount;
                CountDAO.updateCount(c);
            }
            
        }
    }
}
