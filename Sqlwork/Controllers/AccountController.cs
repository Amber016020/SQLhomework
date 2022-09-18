using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DBClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sqlwork.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBClassLibrary.Models.THCSContext THCSContext;
        public AccountController(DBClassLibrary.Models.THCSContext _THCSContext)
        {
            THCSContext = _THCSContext;
        }//資料庫連線

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User0 ec)
        {
            var result = (from s in THCSContext.User0
                          where s.UserName == ec.UserName
                          select s.UserPassword
                          ).LastOrDefault();
            if (result == null)
                ViewBag.message = "無此帳戶... ，建議創立一個!";

            else if (result == ec.UserPassword)
                ViewBag.message = "歡迎 " + ec.UserName + "，已成功登入...!";
            else
                ViewBag.message = "密碼錯誤...  ，請再試一次!";
            return View(ec);
        }
    }
}
