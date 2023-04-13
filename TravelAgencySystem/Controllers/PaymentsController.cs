using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;
using System.Collections.Generic;

namespace TravelAgencySystem.Controllers
{
    public class PaymentsController :Controller
    {

        //Method to Load Categories in Add Item View Page

        private void loadPakages ()
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


        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public PaymentsController (TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult PaymentsList ()
        {
            return View(_Db.tblPayments.ToList());
        }

        public async Task<IActionResult> AddPayments (PaymentsEntity obj)
        {
            loadPakages();
            return View(obj);
        }
        public async Task<IActionResult> SavePayments (PaymentsEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.PaymentId == 0)
                    {
                        _Db.tblPayments.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("PaymentsList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("PaymentsList");
            }
        }

        public async Task<IActionResult> DeletePayments (int PaymentId)
        {
            try
            {
                var item = await _Db.tblPayments.FindAsync(PaymentId)
    ;
                if (item != null)
                {
                    _Db.tblPayments.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("PaymentsList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("PaymentsList");
            }
        }
    }
}



