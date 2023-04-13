using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;
using System.Collections.Generic;

namespace TravelAgencySystem.Controllers
{
    public class HotelBookingController : Controller
    {

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

        public HotelBookingController (TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult HotelBookingList ()
        {
            return View(_Db.tblHotelBooking.ToList());
        }

        public async Task<IActionResult> AddHotelBooking (HotelBookingEntity obj)
        {
            loadCustomer();
            return View(obj);
        }
        public async Task<IActionResult> SaveHotelBooking (HotelBookingEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.HotelId == 0)
                    {
                        _Db.tblHotelBooking.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("HotelBookingList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("HotelBookingList");
            }
        }

        public async Task<IActionResult> DeleteHotelBooking (int HotelId )
        {
            try
            {
                var item = await _Db.tblHotelBooking.FindAsync(HotelId)
    ;
                if (item != null)
                {
                    _Db.tblHotelBooking.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("HotelBookingList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("HotelBookingList");
            }
        }
    }
}



    