using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    internal class ReadingStatus
    {
        [Key]
        [MaxLength(30)]
        public int Id { get; set; }

        [MinLength(6)]
        [MaxLength(50)]
        public string UserEmail { get; set; }

        [MaxLength(30)]
        public int BookISBN { get; set; }

        public int PagesWritten { get; set; }

        public DateTime StartOfReading { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        public double Rating { get; set; }

        public string BookStatus { get; set; }
    }
}
