using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;
using System.Collections.Generic;

namespace TravelAgencySystem.Controllers
{
    public class ReservationController : Controller
    {
        //Method to Load Categories in Add Item View Page

        private void loadPakages()
        {
            try
            {
                List<PakagesEntity> PakagesList = new List<PakagesEntity>();
                PakagesList = _Db.tblPakages.ToList();

                PakagesList.Insert(0, new PakagesEntity { PakageId = 0, PakageName = "Please Select" });

                ViewBag.PakagesList = PakagesList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadHotelBooking ()
        {
            try
            {
                List<HotelBookingEntity> HotelBookingList = new List<HotelBookingEntity>();
                HotelBookingList = _Db.tblHotelBooking.ToList();

                HotelBookingList.Insert(0, new HotelBookingEntity { HotelId = 0, HotelName = "Please Select" });

                ViewBag.HotelBookingList = HotelBookingList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadFlightBooking()
        {
            try
            {
                List<FlightBookingEntity> FlightBookingList = new List<FlightBookingEntity>();
                FlightBookingList = _Db.tblFlightBooking.ToList();

                FlightBookingList.Insert(0, new FlightBookingEntity { FlightId = 0, FlightNumber = "Please Select" });

                ViewBag.FlightBookingList = FlightBookingList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadTourGuide()
        {
            try
            {
                List<TourGuideEntity> TourGuideList = new List<TourGuideEntity>();
                TourGuideList = _Db.tblTourGuide.ToList();

                TourGuideList.Insert(0, new TourGuideEntity { GuideId = 0, GuideName = "Please Select" });

                ViewBag.TourGuideList = TourGuideList;

            }
            catch (Exception ex)
            {


            }
        }

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

        private void loadCabs()
        {
            try
            {
                List<CabsEntity> CabsList = new List<CabsEntity>();
                CabsList = _Db.tblCabs.ToList();

                CabsList.Insert(0, new CabsEntity { CabId = 0, CabName = "Please Select" });

                ViewBag.CabsList = CabsList;

            }
            catch (Exception ex)
            {


            }
        }

        private void loadPayments()
        {
            try
            {
                List<PaymentsEntity> PaymentsList = new List<PaymentsEntity>();
                PaymentsList = _Db.tblPayments.ToList();

                PaymentsList.Insert(0, new PaymentsEntity { PaymentId = 0, PaymentAmount = "Please Select" });

                ViewBag.PaymentsList = PaymentsList;

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

        public ReservationController (TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult ReservationList()
        {
            return View(_Db.tblReservation.ToList());
        }

        public async Task<IActionResult> AddReservation (ReservationEntity obj)
        {
            loadPakages();
            loadHotelBooking();
            loadFlightBooking();
            loadTourGuide();
            loadCustomer();
            loadCabs();
            loadPayments();
            return View(obj);
        }
        public async Task<IActionResult> SaveReservation(ReservationEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.ResId == 0)
                    {
                        _Db.tblReservation.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("ReservationList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("ReservationList");
            }
        }

        public async Task<IActionResult> DeleteReservation (int ResId )
        {
            try
            {
                var item = await _Db.tblReservation.FindAsync(ResId)
    ;
                if (item != null)
                {
                    _Db.tblReservation.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("ReservationList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("ReservationList");
            }
        }
    }
}

   