using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
//using DBClassLibrary.Models;
using DBClassLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Sqlwork.Models;

namespace Sqlwork.Controllers
{
    public class HomeController : Controller
    {
        //資料庫連線
        private readonly DBClassLibrary.Models.THCSContext THCSContext;
        public HomeController(DBClassLibrary.Models.THCSContext _THCSContext)
        {
            THCSContext = _THCSContext;
        }//資料庫連線

        public IActionResult HomePage()
        {
            ViewData["Message"] = "首頁";

            return View();
        }

        public IActionResult Index()
        {
            var result = (from a in THCSContext.Dog
                          select new DogViewModels
                          {
                              DogId = a.DogId,
                              DogKind = a.DogKind,
                              DogFeature = a.DogFeature,
                              DogFeature1 = a.DogFeature1,
                              DogType = a.DogType,
                              DogPicture = a.DogPicture
                          }).ToList();
            return View(result);
        }

        public IActionResult AboutPage()
        {
            ViewData["Message"] = "關於我們";

            return View();
        }

        public ActionResult SmallDog()
        {
            var result = (from a in THCSContext.Dog
                          where a.DogType == "小型犬"
                          select new DogViewModels
                          {
                              DogPicture = a.DogPicture,
                              DogId = a.DogId,
                              DogKind = a.DogKind,
                              DogType = a.DogType

                          }
                          ).ToList();
            return View(result);
        }
        public ActionResult MediumDog()
        {
            var result = (from a in THCSContext.Dog
                          where a.DogType == "中型犬"
                          select new DogViewModels
                          {
                              DogPicture = a.DogPicture,
                              DogId = a.DogId,
                              DogKind = a.DogKind,
                              DogType = a.DogType

                          }
                          ).ToList();
            return View(result);
        }
        public ActionResult BigDog()
        {
            var result = (from a in THCSContext.Dog
                          where a.DogType == "大型犬"
                          select new DogViewModels
                          {
                              DogPicture = a.DogPicture,
                              DogId = a.DogId,
                              DogKind = a.DogKind,
                              DogType = a.DogType

                          }
                          ).ToList();
            return View(result);
        }
        public ActionResult SuperBigDog()
        {
            var result = (from a in THCSContext.Dog
                          where a.DogType == "超大型犬"
                          select new DogViewModels
                          {
                              DogPicture = a.DogPicture,
                              DogId = a.DogId,
                              DogKind = a.DogKind,
                              DogType = a.DogType

                          }
                          ).ToList();
            return View(result);
        }
        public ActionResult LongHair()
        {
            var result = (from a in THCSContext.Cat
                          where a.CatHair == "長毛"
                          select new CatViewModel
                          {
                              CatPicture = a.CatPicture,
                              CatId = a.CatId,
                              CatKind = a.CatKind,
                              CatHair = a.CatHair

                          }
                          ).ToList();
            return View(result);
        }

        public ActionResult ShortHairs()
        {
            var result = (from a in THCSContext.Cat
                          where a.CatHair == "短毛"
                          select new CatViewModel
                          {
                              CatPicture = a.CatPicture,
                              CatId = a.CatId,
                              CatKind = a.CatKind,
                              CatHair = a.CatHair

                          }
                          ).ToList();
            return View(result);
        }

        public ActionResult SpooltHairs()
        {
            var result = (from a in THCSContext.Cat
                          where a.CatHair == "捲毛"
                          select new CatViewModel
                          {
                              CatPicture = a.CatPicture,
                              CatId = a.CatId,
                              CatKind = a.CatKind,
                              CatHair = a.CatHair

                          }
                          ).ToList();
            return View(result);
        }


        public ActionResult Details(int id)
        {
                var result = (from s in THCSContext.Dog
                              where s.DogId == id
                              select s).FirstOrDefault();
                
                return View(result);
        }

        public IActionResult CatIntroduction()
        {
            var result = (from a in THCSContext.Cat
                          select new Cat
                          {
                              CatId = a.CatId,
                              CatKind = a.CatKind,
                              CatFocus = a.CatFocus,
                              CatFocusIssues = a.CatFocusIssues,
                              CatFeature = a.CatFeature,
                              CatHair = a.CatHair,
                              CatPersonality = a.CatPersonality,
                              CatPicture = a.CatPicture
                          }).ToList();
            return View(result);
        }
        public ActionResult CatIntroductionDetails(int id)
        {
            var result = (from s in THCSContext.Cat
                          where s.CatId == id
                          select s).FirstOrDefault();

            return View(result);
        }

        public IActionResult About()
        {
            var result = (from a in THCSContext.Animal
                          join b in THCSContext.AnimalDetal on a.AnimalId equals b.AnimalId into table1
                          from b in table1.DefaultIfEmpty()
                          join c in THCSContext.AnimalPlace on a.AnimalId equals c.AnimalId into table2
                          from c in table2.DefaultIfEmpty()
                          join d in THCSContext.AnimalHeathe on a.AnimalId equals d.AnimalId into table3
                          from d in table3.DefaultIfEmpty()
                          join e in THCSContext.AnimalTime on a.AnimalId equals e.AnimalId into table4
                          from e in table4.DefaultIfEmpty()
                          join h in THCSContext.Shelter on a.AnimalShelterPkid equals h.ShelterPkid into table5
                          from h in table5.DefaultIfEmpty()
                          join i in THCSContext.Area on h.AreaPkid equals i.AreaPkid into table6
                          from i in table6.DefaultIfEmpty()
                          select new DBClassLibrary.ViewModels.AnimalViewModels
                          {
                              animal = a,
                              animaldetal = b,
                              animalPlace = c,
                              animalHeathe = d,
                              animalTime = e,
                              shelter = h,
                              area = i
                          }).Take(100).ToList();
            return View(result);
        }

        public ActionResult AnimalDetails(int id)
        {
            var result = (from a in THCSContext.Animal
                          join b in THCSContext.AnimalDetal on a.AnimalId equals b.AnimalId into table1
                          from b in table1.DefaultIfEmpty()
                          join c in THCSContext.AnimalPlace on a.AnimalId equals c.AnimalId into table2
                          from c in table2.DefaultIfEmpty()
                          join d in THCSContext.AnimalHeathe on a.AnimalId equals d.AnimalId into table3
                          from d in table3.DefaultIfEmpty()
                          join e in THCSContext.AnimalTime on a.AnimalId equals e.AnimalId into table4
                          from e in table4.DefaultIfEmpty()
                          join h in THCSContext.Shelter on a.AnimalShelterPkid equals h.ShelterPkid into table5
                          from h in table5.DefaultIfEmpty()
                          join i in THCSContext.Area on h.AreaPkid equals i.AreaPkid into table6
                          from i in table6.DefaultIfEmpty()
                          where a.AnimalId == id
                          select new DBClassLibrary.ViewModels.AnimalViewModels
                          {
                              animal = a,
                              animaldetal = b,
                              animalPlace = c,
                              animalHeathe = d,
                              animalTime = e,
                              shelter = h,
                              area = i
                          }).ToList();

            return View(result);
        }

        public IActionResult Account()
        {
            var result = (from s in THCSContext.User
                          from d in THCSContext.Animal
                          select s).FirstOrDefault();

            return View();
        }

        public IActionResult Register()
        {
            ViewData["Message"] = "測試";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
