﻿using BantuanRumahLayakHuni.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BantuanRumahLayakHuni.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (Session["nama"] != null)
            {
                return RedirectToAction("index", "home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index", "Login");
        }


        [HttpPost]
        [Route("Login")]
        public ActionResult Login(VMLogin login)
        {
            bool remarks = false;
            string message = "Username or Password incorrect.";

            try
            {
                var result = login.Login();
                if (result == null)
                {
                    return Json(new { Remarks = remarks, Message = message, JsonRequestBehavior.AllowGet });
                }

                Session["nama"] = result.nama;
                remarks = true;
                message = "Login success";

                return Json(new { Remarks = remarks, Message = message, JsonRequestBehavior.AllowGet });

            }
            catch (Exception e)
            {
                return Json(new { Remarks = remarks, e.Message, JsonRequestBehavior.AllowGet });
            }
        }
    }
}