using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;

namespace BaiTap2.Controllers
{
    public class DemoBT2Controller : Controller
    {
        //khai bao doi tuong can ke thua
        GiaiPhuongTrinh Gpt = new GiaiPhuongTrinh();
        // GET: DemoBT2
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soX, string soY)
        {
            double soa = Convert.ToDouble(soX);
            double sob = Convert.ToDouble(soY);
            //ke thua phuong thuc TimX
            double gt_x = Gpt.Timx(soa, sob);
            ViewBag.timgtx = gt_x;
            return View();
        }
    }
}