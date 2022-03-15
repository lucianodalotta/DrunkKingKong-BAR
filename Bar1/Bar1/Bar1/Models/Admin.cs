using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bar1.Models
{
    public class Admin
    {
        public Admin(string usuario, string pass)
        {
            Usuario = usuario;
            Pass = pass;
        }

        public String Usuario { get; set; }
        public String Pass { get; set; }
    }



}