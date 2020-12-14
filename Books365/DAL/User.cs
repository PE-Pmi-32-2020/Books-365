using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    public class User
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Key]
        [MinLength(6)]
        [MaxLength(50)]
        public string Email { get; set; }

        [MinLength(6)]
        [MaxLength(30)]
        public string Password { get; set; }

        [MinLength(4)]
        [MaxLength(4)]
        public int SecretPin { get; set; }


    }
}
