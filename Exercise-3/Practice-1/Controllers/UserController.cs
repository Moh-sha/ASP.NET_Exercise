using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult User()
        {

            var UserModel = new UserModel()
            {
                ID = 1,
                Name = "Test",
                Email = "Test@gmail.com",
                Password = "password",  



            };

            return View(UserModel);

        }


    }
}