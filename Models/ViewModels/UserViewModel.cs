using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.ViewModels
{
    class UserViewModel : BaseViewModel
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public DateTime? LastAccessDate { get; set; }
        public String DisplayName { get; set; }
        public Boolean Enabled { get; set; }
        public Boolean Locked { get; set; }
        public DateTime? LockedDate { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }

        [Display(Name="Recordar contraseña")]
        public Boolean RememberMe { get; set; }


    }
}
