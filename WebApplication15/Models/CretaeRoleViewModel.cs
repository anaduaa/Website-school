using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    public class CretaeRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }

    }

}
