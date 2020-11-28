using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    internal class Book
    {
        [Key]
        [MaxLength(30)]
        public int ISBN { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(4)]
        public int Year { get; set; }

        [MaxLength(50)]
        public string Author { get; set; }
    }
}
