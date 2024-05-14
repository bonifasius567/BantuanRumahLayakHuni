using BantuanRumahLayakHuni.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BantuanRumahLayakHuni.ViewModels
{
    public class VMLogin
    {
        public string email { get; set; }
        public string password { get; set; }

        DB_SPK_PBRLHDataContext db = new DB_SPK_PBRLHDataContext(ConfigurationManager.ConnectionStrings["DB_SPK_PBRLHConnectionString"].ConnectionString);

        public TBL_T_LOGIN Login()
        {
            var data = db.TBL_T_LOGINs.Where(a => a.email == email & a.password == password).FirstOrDefault();
            return data;
        }
    }
}