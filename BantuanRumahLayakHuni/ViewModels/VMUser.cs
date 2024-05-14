using BantuanRumahLayakHuni.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace BantuanRumahLayakHuni.ViewModels
{

    public class VMUser
    {
        DB_SPK_PBRLHDataContext db = new DB_SPK_PBRLHDataContext(ConfigurationManager.ConnectionStrings["DB_SPK_PBRLHConnectionString"].ConnectionString);

        public IList<TBL_T_LOGIN> GetUser()
        {
            var data = db.TBL_T_LOGINs.ToList();
            return data;
        }

        public TBL_T_LOGIN GetUser(int id)
        {
            var data = db.TBL_T_LOGINs.Where(a => a.id == id).FirstOrDefault();
            return data;
        }

        public void DeleteUser(int id)
        {
            var data = db.TBL_T_LOGINs.Where(a => a.id == id).FirstOrDefault();
            db.TBL_T_LOGINs.DeleteOnSubmit(data);
            db.SubmitChanges();
        }

        public void InsertUser(TBL_T_LOGIN data)
        {
            db.TBL_T_LOGINs.InsertOnSubmit(data);
            db.SubmitChanges();
        }

        public bool isEmailExist(string email)
        {
            var data = db.TBL_T_LOGINs.Where(a => a.email == email).FirstOrDefault();
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public bool isEmailUpdateExist(string email, int id)
        {
            var data = db.TBL_T_LOGINs.Where(a => a.email == email && a.id != id).FirstOrDefault();
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public void UpdateUser(TBL_T_LOGIN data)
        {
            var update = db.TBL_T_LOGINs.Where(a=> a.id == data.id).FirstOrDefault();
            update.password = data.password;
            update.tanggal_lahir = data.tanggal_lahir;
            update.alamat = data.alamat;
            update.nama = data.nama;
            update.email = data.email;

            db.SubmitChanges();
        }


    }
}