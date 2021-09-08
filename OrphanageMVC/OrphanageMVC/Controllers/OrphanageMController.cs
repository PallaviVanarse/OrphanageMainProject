
using OrphanageMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OrphanageMVC.Controllers
{
    public class OrphanageMController : Controller
    {
        ////GET: OrphanageM
        //public ActionResult Index()
        //{
        //    IEnumerable<OrphanageRegistrationView> orpObj = null;

        //    using(var hc=new HttpClient())
        //    {
        //        hc.BaseAddress = new Uri("https://localhost:44309/api/Orphanage");
        //        var consumeapi = hc.GetAsync("Orphanage");
        //        consumeapi.Wait();
        //        var readdata = consumeapi.Result;
        //        if (readdata.IsSuccessStatusCode)
        //        {
        //            var displaydata = readdata.Content.ReadAsAsync<IList<OrphanageRegistrationView>>();

        //            displaydata.Wait();

        //            orpObj = displaydata.Result;
        //        }
        //        else
        //        {
        //            orpObj = Enumerable.Empty<OrphanageRegistrationView>();
        //            ModelState.AddModelError(string.Empty, "Server Error Occured!");
        //        }
        //    }
        //    //HttpClient hc = new HttpClient();









        //    return View(orpObj);
        //}

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrphanageRegistrationView orp)
        {
            HttpClient hc = new HttpClient();

            hc.BaseAddress = new Uri("https://localhost:44309/api/Orphanage");
            var consumeapi = hc.PostAsJsonAsync<OrphanageRegistrationView>("Orphanage", orp);

            consumeapi.Wait();

            var readdata = consumeapi.Result;

            if (readdata.IsSuccessStatusCode)
            {

                TempData["message"] = "Registration Successfull... Please Login!";
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Index");
            }
            return View("Create");
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(OrphanageRegistrationView orp)
        {
            if (ModelState.IsValid)
            {

                FormsAuthentication.SetAuthCookie(orp.oId.ToString(),true);
                Session["Oid"] = orp.oId.ToString();
                
                HttpClient hc = new HttpClient();

                hc.BaseAddress = new Uri("https://localhost:44309/api/Login");
                var consumeapi = hc.PostAsJsonAsync<OrphanageRegistrationView>("Login", orp);

                consumeapi.Wait();

                var readdata = consumeapi.Result;

                if (readdata.IsSuccessStatusCode)
                {

                    TempData["message"] = "Login Successful!";
                    //return RedirectToAction("Index", "Home");
                    return View("Dashboard");
                }
                else
                {
                    TempData["message"] = "Login Failed !Enter correct Credentials!";
                    return View("Index");
                }
                
            }
            return View("Create");
        }


        public ActionResult ChildRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChildRegistration(childRegisteration child)
        {
            HttpClient hc = new HttpClient();


            child.oId = int.Parse(Session["Oid"].ToString());
            hc.BaseAddress = new Uri("https://localhost:44309/api/Child");
            var consumeapi = hc.PostAsJsonAsync<childRegisteration>("Child", child);

            consumeapi.Wait();

            var readdata = consumeapi.Result;

            if (readdata.IsSuccessStatusCode)
            {

                TempData["message"] = "Child Registration Successfull... Please Login!";
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Index");
            }
            return View("Dashboard");
        }



        public ActionResult OrphanageRequirement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrphanageRequirement(reqTable child)
        {
            HttpClient hc = new HttpClient();


            child.oId = int.Parse(Session["Oid"].ToString());
            hc.BaseAddress = new Uri("https://localhost:44309/api/Child");
            var consumeapi = hc.PostAsJsonAsync<reqTable>("Child", child);

            consumeapi.Wait();

            var readdata = consumeapi.Result;

            if (readdata.IsSuccessStatusCode)
            {

                TempData["message"] = "Child Registration Successfull... Please Login!";
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Index");
            }
            return View("Dashboard");
        }
    }
}