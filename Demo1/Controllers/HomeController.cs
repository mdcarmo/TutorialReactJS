﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public JsonResult GetName()
		{
			return Json(new { name = "World from server side" }, JsonRequestBehavior.AllowGet);
		}

	}
}