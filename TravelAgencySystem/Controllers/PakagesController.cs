using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;

namespace TravelAgencySystem.Controllers
{
    public class PakagesController : Controller

    {


        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public PakagesController(TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult PakagesList()
        {
            return View(_Db.tblPakages.ToList());
        }

        public async Task<IActionResult>AddPakages(PakagesEntity obj)
        {
            return View(obj);
        }
        public async Task<IActionResult>SavePakages(PakagesEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.PakageId == 0)
                    {
                        _Db.tblPakages.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("PakagesList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("PakagesList");
            }
        }

        public async Task<IActionResult> DeletePakages(int PakageId)
        {
            try
            {
                var item = await _Db.tblPakages.FindAsync(PakageId)
    ;
                if (item != null)
                {
                    _Db.tblPakages.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("PakagesList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("PakagesList");
            }
        }
    }
}



