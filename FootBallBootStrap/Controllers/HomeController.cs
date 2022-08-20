using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootBallBootStrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<FootBallBootStrap> qry = new List<FootBallBootStrap>();
            using (Sample4Entities dc = new Sample4Entities())
            {
                qry = (from s in dc.FootBallLeagues
                       where s.Status == "Win"

                       select new FootBallBootStrap
                       {
                           MatchID = s.MatchID,
                           TeamName1 = s.TeamName1,
                           TeamName2 = s.TeamName2,
                           Status = s.Status,
                           WinningTeam = s.WinningTeam,
                           Points = s.Points,


                       }).ToList();

            }
            return View(qry);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}