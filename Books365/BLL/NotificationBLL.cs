using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Books365.DAL;
namespace Books365.BLL
{
    class NotificationBLL
    {
        public DataTable GetNotification()
        {

            try
            {
                NotificationDAL ndal = new NotificationDAL();
                return ndal.ReadNotifications();
            }
            catch
            {
                throw new Exception("Unable to get DataTable Notification");
            }
        }
    }
}
