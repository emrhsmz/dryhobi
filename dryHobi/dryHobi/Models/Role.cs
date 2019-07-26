using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dryHobi.Models
{
    public class Role
    {
        public int ID { get; set; }
        [Display(Name ="Rol")]
        public string Role { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}