using Farg.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Farg.Models;



namespace Farg.Controllers
{
    
    public class RootController : Controller
    {
        public static List<CarsDetail> carsDetails = new List<CarsDetail>();
        public RootController()
        {
            carsDetails = new List<CarsDetail>();
            carsDetails.AddRange(new List<CarsDetail>{new CarsDetail
            {
                Color = "Black",
                Name="Test1",
                Doors = "2/2",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2017"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2017",
                Power = "86",
                seats = 6,
                Type = CarType.New,
                CarPics=new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-1-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test2",
                Engine_size = "1800 ",
                Fuel = "Petrol",
                F_registration = Convert.ToDateTime("01/01/2010"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2010",
                Power = "86",
                seats = 6,
                Type = CarType.New,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-1-370x270.jpg"
                    }
                }
            }
            ,
            new CarsDetail
            {
                Color = "Black",
                Name="Test3",
                Doors = "2/2",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2011"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2011",
                Power = "86",
                seats = 6,
                Type = CarType.New,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-2-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test3",
                Engine_size = "1800 ",
                Fuel = "Petrol",
                F_registration = Convert.ToDateTime("01/01/2012"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2012",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-3-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test4",
                Engine_size = "1800 ",
                Fuel = "Petrol",
                F_registration = Convert.ToDateTime("01/01/2014"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2014",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-4-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test5",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2016"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2016",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-5-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test6",
                Engine_size = "1800 ",
                Fuel = "Petrol",
                F_registration = Convert.ToDateTime("01/01/2019"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2019",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-6-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test6",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2018"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2010",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-1-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "Black",
                Doors = "2/2",
                Name="Test8",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2015"),
                Gearbox = "Automated",
                Mileage = "500",
                Model = "2015",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-2-370x270.jpg"
                    }
                }
            },
            new CarsDetail
            {
                Color = "White",
                Doors = "2/2",
                Name="Test9",
                Engine_size = "1800 ",
                Fuel = "Diesl",
                F_registration = Convert.ToDateTime("01/01/2020"),
                Gearbox = "Automated",

                Mileage = "500",
                Model = "2020",
                Power = "86",
                seats = 6,
                Type = CarType.Used,
                CarPics = new List<CarPic>
                {
                    new CarPic
                    {
                        Path   = "/images/product-3-370x270.jpg"
                    }
                }
            }
            }
            );
        }
        // GET: Root
        public ActionResult Home()
        {
            ViewBag.Models = carsDetails.Select(x => x.Model).Distinct();
            ViewBag.Makes = carsDetails.Select(x => x.Name).Distinct();
            return View();
        }
        public ActionResult BuyOffLease()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult BuyTradeIn(string cut, string name, string cm)
        {

            var cars = carsDetails.Where(x => x.Model.ToLower().Contains(cm + "") || x.Name.ToLower().Contains(name + "")).ToList();
            if (!string.IsNullOrEmpty(cut))
            {
                cars = carsDetails.Where(x => 
                 (cut == "new" ? x.Type == CarType.New : x.Type == CarType.Used)
                 ).ToList();
            }
            ViewBag.Models = carsDetails.Select(x => x.Model).Distinct();
            ViewBag.Makes = carsDetails.Select(x => x.Name).Distinct();
            ViewBag.Color = carsDetails.Select(x => x.Color).Distinct();
            ViewBag.Types = carsDetails.Select(x => x.Type).Distinct();
            ViewBag.Milleages = carsDetails.Select(x => x.Mileage).Distinct();
            ViewBag.Trims = new string[0];
            ViewBag.Years = carsDetails.Select(x => x.Model).Distinct();
            return View(cars);
        }
        public ActionResult BuyTradeIn_search(string cut, string year, string make,string Model,string trim,string color,string type,string milleage)
        {

            var cars = carsDetails.Where(x => x.Model.ToLower().Contains(Model + "") || x.Model.ToLower().Contains(year+ "")
            || x.Color.ToLower().Contains(color+ "")
            //|| x.Type==type 
            || x.Mileage.ToLower().Contains(milleage + "")
            ).ToList();
            if (!string.IsNullOrEmpty(cut))
            {
                cars = carsDetails.Where(x =>
                 (cut == "new" ? x.Type == CarType.New : x.Type == CarType.Used)
                 ).ToList();
            }
            ViewBag.Models = carsDetails.Select(x => x.Model).Distinct();
            ViewBag.Makes = carsDetails.Select(x => x.Name).Distinct();
            ViewBag.Color = carsDetails.Select(x => x.Color).Distinct();
            ViewBag.Types= carsDetails.Select(x => x.Type).Distinct();
            ViewBag.Milleages = carsDetails.Select(x => x.Mileage).Distinct();
            ViewBag.Trims = new string[0];
            ViewBag.Years = carsDetails.Select(x => x.Model).Distinct(); 

            return View("BuyTradeIn", cars);
        }
        public ActionResult SearchInventory(string value)
        {

            var cars = carsDetails.Where(x => x.Model.ToLower().Contains(value + "") || x.Model.ToLower().Contains(value + "")
            || x.Color.ToLower().Contains(value + "")
            //|| x.Type==type 
            || x.Mileage.ToLower().Contains(value + "")
            ).ToList();
            ViewBag.Models = carsDetails.Select(x => x.Model).Distinct();
            ViewBag.Makes = carsDetails.Select(x => x.Name).Distinct();
            ViewBag.Color = carsDetails.Select(x => x.Color).Distinct();
            ViewBag.Types = carsDetails.Select(x => x.Type).Distinct();
            ViewBag.Milleages = carsDetails.Select(x => x.Mileage).Distinct();
            ViewBag.Trims = new string[0];
            ViewBag.Years = carsDetails.Select(x => x.Model).Distinct();

            return View("BuyTradeIn", cars);
        }
        

        public ActionResult SellOrTradeIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellOrTradeIn(SellOrTradeInForm form)
        {
            try
            {
                using (FargEntities db = new FargEntities())
                {
                    db.SellOrTradeInForms.Add(form);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                return Json(ex);
            }
            return RedirectToAction("SellOrTradeIn", "Root");
        }
        public ActionResult Finance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Finance(FinanceForm form)
        
        {
            try
            {
                using (FargEntities db = new FargEntities())
                {
                    db.FinanceForms.Add(form);
                    db.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                return View(ex);
            }
            return RedirectToAction("Finance","Root");
        }

        public ActionResult More()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Terms()
        {
            return View();
        }
        public ActionResult Testimonials()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetCarsResult(CarsDetail _carsDetail)
        {
            if (_carsDetail.SearchCriteria == SearchCriteria.singleName)
            {
                var res = carsDetails.Where(x => x.Name.Contains(_carsDetail.Name));
                return Json(res);
            }
            else
            {
                var res = carsDetails.Where(x => x.Name.Contains(_carsDetail.Name) || x.Model.Contains(_carsDetail.Model) || x.Price <= _carsDetail.Price);
                return Json(res);
            }
        }

        [HttpPost]
        public JsonResult GetInvventory(string searchVal)
        {
            var res = carsDetails.Where(x => x.Name.Contains(searchVal));
            return Json(res);

        }


        public ActionResult CarDetails() {
            return View();
        }
    }
}