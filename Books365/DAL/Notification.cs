using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    public class Notification
    {
        [Key]
        public string Message { get; set; }

        [MinLength(6)]
        [MaxLength(50)]
        public string Email { get; set; }

        public DateTime Date { get; set; }

    }
}
