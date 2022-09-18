using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBClassLibrary.Models;

namespace Sqlwork.Controllers
{
    
    public class NewRecordController : Controller
    {
        int id = 0;
        private readonly DBClassLibrary.Models.THCSContext THCSContext;
        public NewRecordController(DBClassLibrary.Models.THCSContext _THCSContext)
        {
            THCSContext = _THCSContext;
        }//資料庫連線
        //private readonly ConncetionStringClass _cc;

        //public NewRecordController(ConncetionStringClass cc)
        //{
        //    _cc = cc;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User0 ec)
        {
            var result = (from s in THCSContext.User0
                          select (s.UserId)
                          ).LastOrDefault();
            ec.UserId = result+1;
            THCSContext.Add(ec);
            THCSContext.SaveChanges();
            ViewBag.message = "歡迎 " + ec.UserName + "，已成功註冊...!";
            return View(ec);
        }
    }
}