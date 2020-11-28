using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    internal class EmailOfCurrentUser
    {
        [Key]
        public string Email { get; set; }
    }
}
