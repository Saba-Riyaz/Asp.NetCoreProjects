using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TravelAgencySystem.Controllers
{
    public class CustomerController : Controller
    {
        
    
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public CustomerController(TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult CustomerList()
        {
            return View(_Db.tblCustomer.ToList());
        }

        public async Task<IActionResult> AddCustomer(CustomerEntity obj)
        {
            return View(obj);
        }
        public async Task<IActionResult> SaveCustomer(CustomerEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.CustId == 0)
                    {
                        _Db.tblCustomer.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("CustomerList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("CustomerList");
            }
        }

        public async Task<IActionResult> DeleteCustomer(int CustId )
        {
            try
            {
                var item = await _Db.tblCustomer.FindAsync(CustId)
    ;
                if (item != null)
                {
                    _Db.tblCustomer.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("CustomerList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("CustomerList");
            }
        }
    }
}

