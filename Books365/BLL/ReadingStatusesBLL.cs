using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Books365.DAL;

namespace Books365.BLL
{
    class ReadingStatusesBLL
    {
        public DataTable GetReadingStatuses()
        {

            try
            {
                ReadingStatusesDAL rsdal = new ReadingStatusesDAL();
                return rsdal.ReadReadingStatuses();
            }
            catch
            {
                throw new Exception("Unable to get DataTable ReadingStatuses");
            }
        }
    }
}
