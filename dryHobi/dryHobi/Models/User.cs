using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dryHobi.Models
{
    public class User
    {
        public int ID { get; set; }
        [Display(Name = "Kullanıcı Rolü")]
        public int RoleID { get; set; }
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        [Display(Name = "Adı")]
        public string FirstName { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Son Değişiklik Tarihi")]
        public DateTime ModifyDate { get; set; }
        [Display(Name = "Aktif")]
        public bool isActive { get; set; }
        [Display(Name = "Silindi")]
        public bool isDeleted { get; set; }

    }
}