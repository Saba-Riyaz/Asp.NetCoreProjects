using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using TravelAgencySystem.Models;
using System.Linq;

namespace TravelAgencySystem.Controllers
{
    public class TourGuideController : Controller
    {
    
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly TravelAgencyDBContext _Db;

        public TourGuideController (TravelAgencyDBContext Db)
        {
            _Db = Db;

        }

        public IActionResult TourGuideList ()
        {
            return View(_Db.tblTourGuide.ToList());
        }

        public async Task<IActionResult> AddTourGuide (TourGuideEntity obj)
        {
            return View(obj);
        }
        public async Task<IActionResult> SaveTourGuide (TourGuideEntity obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.GuideId == 0)
                    {
                        _Db.tblTourGuide.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                    return RedirectToAction("TourGuideList");
                }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("TourGuideList");
            }
        }

        public async Task<IActionResult> DeleteTourGuide (int GuideId )
        {
            try
            {
                var item = await _Db.tblTourGuide.FindAsync(GuideId)
    ;
                if (item != null)
                {
                    _Db.tblTourGuide.Remove(item);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("TourGuideList");
            }
            catch (Exception ex)
            {

                return RedirectToAction("TourGuideList");
            }
        }
    }
}

    