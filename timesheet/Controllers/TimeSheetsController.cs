﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timesheet.Controllers
{
    public class TimeSheetsController : Controller
    {
        int ASCENDING_ORDER = 0;
        int DESCENDING_ORDER = 1;

        // GET /TimeSheets...
        public ActionResult Index(int ID = 0, string sortOrder = null, int fromIndex = 0, int range = 20)
        {
            if (ID > 0)
            {
                return ShowDetail(ID);
            }

            int normalizedSortOrder = (sortOrder == "ASC" ? ASCENDING_ORDER : DESCENDING_ORDER);
            return ShowList(normalizedSortOrder, fromIndex, range);
        }

        // GET /TimeSheets/{ID}
        private ActionResult ShowDetail(int ID)
        {
            return View("Detail");
        }

        // GET /TimeSheets
        private ActionResult ShowList(int sortOrder, int fromIndex, int range)
        {
            return View("Index");
        }
    }
}