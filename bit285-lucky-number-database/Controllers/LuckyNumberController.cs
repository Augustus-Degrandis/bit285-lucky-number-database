using bit285_lucky_number_database.Models;
using lucky_number_database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bit285_lucky_number_database.Controllers
{
    public class LuckyNumberController : Controller
    {
        private LuckyNumberDbContext dbc = new LuckyNumberDbContext();

       

        [HttpPost]
        public ActionResult Spin(LuckyNumber lucky)
        {
            LuckyNumber databaseLuck = dbc.LuckyNumbers.Where(m=>m.LuckyNumberID == (int)Session["currentID"]).First();
            //change the balence in the database
            if(databaseLuck.Balance>0)
            {
                databaseLuck.Balance -= 1;
            }
            //update the number in the database using the form submission value
            databaseLuck.Number = lucky.Number;
            //Save to the DataBase
            dbc.SaveChanges();

            return View(databaseLuck);
        }
        // GET: LuckyNumber
        public ActionResult Spin()
        {

            //LuckyNumber myLuck = new LuckyNumber { Number = 7, Balance = 4 };

            return View( );
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LuckyNumber lucky)
        {
            lucky.Balance = 4;
            dbc.LuckyNumbers.Add(lucky);
            dbc.SaveChanges();
            Session["currentID"] = lucky.LuckyNumberID;
            return View("Spin");
        }

        
    }
}