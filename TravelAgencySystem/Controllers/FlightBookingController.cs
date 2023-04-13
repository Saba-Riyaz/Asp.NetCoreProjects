using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;
using System.Collections.Generic;

namespace TravelAgencySystem.Controllers
{
    public class FlightBookingController : Controller

    {


        //Method to Load Categories in Add Item View Page

        private void loadCustomer()
        {
            try
            {
                List<CustomerEntity> CustList = new List<CustomerEntity>();
                CustList = _Db.tblCustomer.ToList();

                CustList.Insert(0, new CustomerEntity { CustId = 0, CustName = "Please Select" });

                ViewBag.CustList = CustList;

            }
            catch (Exception ex)
            {


            }
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public FlightBookingController(TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult FlightBookingList ()
        {
            return View(_Db.tblFlightBooking.ToList());
        }
         
        public async Task<IActionResult> AddFlightBooking(FlightBookingEntity obj)
        {
            loadCustomer();
            return View(obj);
        }
        public async Task<IActionResult> SaveFlightBooking(FlightBookingEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.FlightId == 0)
                    {
                        _Db.tblFlightBooking.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("FlightBookingList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("FlightBookingList");
            }
        }

        public async Task<IActionResult> DeleteFlightBooking (int FlightId)
        {
            try
            {
                var item = await _Db.tblFlightBooking.FindAsync(FlightId)
    ;
                if (item != null)
                {
                    _Db.tblFlightBooking.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("FlightBookingList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("FlightBookingList");
            }
        }
    }
}




    