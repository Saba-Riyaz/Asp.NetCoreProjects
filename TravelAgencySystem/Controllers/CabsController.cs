using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;

namespace TravelAgencySystem.Controllers
{
    public class CabsController : Controller
    {
       
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public CabsController(TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult CabsList()
        {
            return View(_Db.tblCabs.ToList());
        }

        public async Task<IActionResult> AddCabs(CabsEntity obj)
        {
            return View(obj);
        }
        public async Task<IActionResult> SaveCabs (CabsEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.CabId == 0)
                    {
                        _Db.tblCabs.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("CabsList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("CabsList");
            }
        }

        public async Task<IActionResult> DeleteCabs(int CabId)
        {
            try
            {
                var item = await _Db.tblCabs.FindAsync(CabId)
    ;
                if (item != null)
                {
                    _Db.tblCabs.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("CabsList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("CabsList");
            }
        }
    }
}



